using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace FDPort.Class
{
    public class AsyncTCPClient
    {
        public class ConnectedChangedArg : EventArgs
        {
            public bool connected { get; }
            public Socket socket { get; }
            public ConnectedChangedArg(Socket s, bool e)
            {
                connected = e;
                socket = s;
            }
        }
        private Socket clientSocket;

        public bool canSend { get; set; }
        public IPAddress address { get; private set; }

        public int port { get; private set; }
        private bool _IsConnected;
        public bool isConnected { get => _IsConnected; private set { _IsConnected = value;  } }
        public event EventHandler<ConnectedChangedArg> ConnectedChanged;
        public delegate void DataReceived(byte[] vs, int len);
        public DataReceived dataReceived;
        public AsyncTCPClient(IPAddress iP, int port)
        {
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            address = iP;
            this.port = port;
            canSend = true;


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
                ConnectedChanged(this, new ConnectedChangedArg(state, e));
            }
        }
        private IAsyncResult asyncResultRead;//接收数据的异步对象
        private IAsyncResult asyncResultWrite;//发送数据的异步对象

        NetworkStream tcpStream;
        private byte[] buffers = new byte[0x1000];
        public void Start()
        {
            //Task.Factory.StartNew(() =>{
                var result = clientSocket.BeginConnect(address, port, null, null);

                bool success = result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(1), true);//堵塞 直到收到反馈

                if (success && clientSocket.Connected)//成功连接
                {
                    clientSocket.EndConnect(result);//关闭异步对象
                    RaiseConnectedChanged(clientSocket, true);
                    try
                    {
                        tcpStream = new NetworkStream(clientSocket);
                        clientSocket.SetSocketOption(SocketOptionLevel.Tcp, SocketOptionName.NoDelay, true);//无延迟发送

                        Receive();//开始接收


                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    
                    RaiseConnectedChanged(clientSocket, false);
                }

           // });


        }
        public void Receive()
        {
            try
            {
                //异步从流中读取数据
                asyncResultRead = tcpStream.BeginRead(buffers, 0, buffers.Length, EndReceive, clientSocket);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                if (clientSocket.Connected == false)
                {
                    RaiseConnectedChanged(clientSocket, false);
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
                if (clientSocket.Connected == false)
                {
                    RaiseConnectedChanged(clientSocket, false);
                }
            }
        }
        //发送数据
        public void Send(byte[] bytes)
        {
            try
            {
                canSend = false;
                asyncResultWrite = tcpStream.BeginWrite(bytes, 0, bytes.Length, EndSend, clientSocket);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                if (clientSocket.Connected == false)
                {
                    RaiseConnectedChanged(clientSocket, false);
                }
            }
        }

        private void EndSend(IAsyncResult ar)
        {
            try
            {
                tcpStream.EndWrite(ar);
                canSend = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                if (clientSocket.Connected == false)
                {
                    RaiseConnectedChanged(clientSocket, false);
                }
            }

        }
        private void ReadData(byte[] bytes, int offset, int length)
        {
            //在此处理接收到的数据
            dataReceived?.Invoke(common.SubBuffer(bytes,length), length);
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

            if (clientSocket != null)
            {
                RaiseConnectedChanged(clientSocket, false);
                    clientSocket.Shutdown(SocketShutdown.Both);//关闭发送和接收
                
                clientSocket.Close();
                clientSocket.Dispose();
            }

        }

    }
}
