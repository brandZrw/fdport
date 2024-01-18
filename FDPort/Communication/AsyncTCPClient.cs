using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FDPort.Class
{
    public class AsyncTCPClient
    {
        public class ConnctedChangedArg : EventArgs
        {
            public bool Connected { get; }
            public Socket socket { get; }
            public ConnctedChangedArg(Socket s, bool e)
            {
                Connected = e;
                socket = s;
            }
        }
        private Socket ClientSocket;

        public bool CanSend { get; set; }
        public IPAddress Address { get; private set; }

        public int Port { get; private set; }
        private bool _IsConnected;
        public bool IsConnected { get => _IsConnected; private set { _IsConnected = value;  } }
        public event EventHandler<ConnctedChangedArg> ConnectedChanged;
        public delegate void DataReceived(byte[] vs, int len);
        public DataReceived dataReceived;
        public AsyncTCPClient(IPAddress iP, int port)
        {
            ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Address = iP;
            Port = port;
            CanSend = true;


        }
        /// <summary>
        /// 触发客户端连接事件
        /// </summary>
        /// <param name="state"></param>
        private void RaiseConnectedChanged(Socket state, bool e)
        {
            _IsConnected = e;
            if (ConnectedChanged != null)
            {
                ConnectedChanged(this, new ConnctedChangedArg(state, e));
            }
        }
        private IAsyncResult asyncResultRead;//接收数据的异步对象
        private IAsyncResult asyncResultWrite;//发送数据的异步对象

        NetworkStream tcpStream;
        private byte[] buffers = new byte[0x1000];
        public void Start()
        {
            //Task.Factory.StartNew(() =>{
                var result = ClientSocket.BeginConnect(Address, Port, null, null);

                bool success = result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(1), true);//堵塞 直到收到反馈

                if (success && ClientSocket.Connected)//成功连接
                {
                    ClientSocket.EndConnect(result);//关闭异步对象
                    RaiseConnectedChanged(ClientSocket, true);
                    try
                    {
                        tcpStream = new NetworkStream(ClientSocket);
                        ClientSocket.SetSocketOption(SocketOptionLevel.Tcp, SocketOptionName.NoDelay, true);//无延迟发送

                        Receive();//开始接收


                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    
                    RaiseConnectedChanged(ClientSocket, false);
                }

           // });


        }
        public void Receive()
        {
            try
            {
                //异步从流中读取数据
                asyncResultRead = tcpStream.BeginRead(buffers, 0, buffers.Length, EndReceive, ClientSocket);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                if (ClientSocket.Connected == false)
                {
                    RaiseConnectedChanged(ClientSocket, false);
                }
            }

        }

        private void EndReceive(IAsyncResult asyncReceive)
        {
            try
            {
                int len = tcpStream.EndRead(asyncReceive);
                if (len > 0)
                {
                    //读取数据内容
                    ReadData(buffers, 0, len);
                    //再次开启接收
                    Receive();
                }
                else
                {

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                if (ClientSocket.Connected == false)
                {
                    RaiseConnectedChanged(ClientSocket, false);
                }
            }
        }
        //发送数据
        public void Send(byte[] bytes)
        {
            try
            {
                CanSend = false;
                asyncResultWrite = tcpStream.BeginWrite(bytes, 0, bytes.Length, EndSend, ClientSocket);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                if (ClientSocket.Connected == false)
                {
                    RaiseConnectedChanged(ClientSocket, false);
                }
            }
        }

        private void EndSend(IAsyncResult ar)
        {
            try
            {
                tcpStream.EndWrite(ar);
                CanSend = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                if (ClientSocket.Connected == false)
                {
                    RaiseConnectedChanged(ClientSocket, false);
                }
            }

        }
        private void ReadData(byte[] bytes, int offset, int length)
        {
            //在此处理接收到的数据
            dataReceived?.Invoke(bytes.Take(length).ToArray(), length);
        }
        public void Stop()
        {
            if (asyncResultRead != null && !asyncResultRead.IsCompleted)
            {
                asyncResultRead.AsyncWaitHandle.Close();
            }

            if (asyncResultWrite != null && !asyncResultWrite.IsCompleted)
            {
                asyncResultWrite.AsyncWaitHandle.Close();
            }
            if (tcpStream != null)
            {
                tcpStream.Close();
                tcpStream.Dispose();//释放流
            }

            if (ClientSocket != null)
            {
                RaiseConnectedChanged(ClientSocket, false);
                    ClientSocket.Shutdown(SocketShutdown.Both);//关闭发送和接收
                
                ClientSocket.Close();
                ClientSocket.Dispose();
            }

        }

    }
}
