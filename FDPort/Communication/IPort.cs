using FDPort.Class;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FDPort.Communication
{
    abstract public class PortBase
    {
        /// <summary>
        /// 设置参数
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        abstract public void setParam(string a, string b);
        /// <summary>
        /// 发送函数
        /// </summary>
        /// <param name="b"></param>
        abstract public void write(byte[] b, IPEndPoint iP = null);


        /// <summary>
        /// 是否连接成功
        /// </summary>
        /// <returns></returns>
        abstract public bool Connected();

        /// <summary>
        /// 关闭端口
        /// </summary>
        abstract public void close();

        /// <summary>
        /// 打开端口
        /// </summary>
        abstract public void open();


        public delegate void DataRecHandler(object sender, PortBase from,byte[] b);
        public event DataRecHandler DataRecEvent;
        protected virtual void OnDataRec(object sender, PortBase from,byte[] b)
        {
            DataRecEvent?.Invoke(sender,from,b);
            Project.mainForm.dataRec.Rec(sender,from, b, b.Length);
        }

        public string name { get; set; }
        public string param1 { get; set; }
        public string param2 { get; set; }

        /// <summary>
        /// 类型，1.串口，2.客户端，3.服务端
        /// </summary>
        public int type { get; set; }
    }

    public class PortSerial : PortBase
    {
        [JsonIgnore]
        public SerialPort port;
        public override void setParam(string com, string baud)
        {
            param1 = com;
            param2 = baud;
            port.PortName = com;
            port.BaudRate = Convert.ToInt32( baud);
            name = "serial-" + com + ":" + param2;
        }
        public PortSerial()
        {
            port = new SerialPort();
            
            type = 1;
            port.DataReceived += SerialPort_DataReceived;
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int len = port.BytesToRead;

                if (len <= 0)
                {
                    return;
                }
                byte[] vs = new byte[len];
                port.Read(vs, 0, len);
                OnDataRec(null,this,vs);
                //Project.mainForm.dataRec.Rec(vs, len);
            }
            catch (Exception exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }
        }

        public override void write(byte[] b,IPEndPoint point = null)
        {
            port.Write(b,0,b.Length);
        }

        public override bool Connected()
        {
            return port.IsOpen;
        }

        public override void close()
        {
            port?.Close();
        }

        public override void open()
        {
            port?.Open();
        }
    }
    public class PortTCPClient : PortBase
    {
        [JsonIgnore]
        AsyncTCPClient tcpClient;

        public delegate void ConnectedChangedHandler(object sender, AsyncTCPClient.ConnctedChangedArg e);
        public event ConnectedChangedHandler ConnectedChangedEvent;

        public override void setParam(string iP, string port)
        {
            IPAddress address;
            param1 = iP;
            param2 = port;
            if( IPAddress.TryParse(iP,out address))
            {
                tcpClient = new AsyncTCPClient(address,Convert.ToInt32(port));
                name = "client-" + iP.ToString() + ":" + port.ToString();
                tcpClient.dataReceived += TCP_DataRecv;
                tcpClient.ConnectedChanged += TcpClient_ConnectedChanged;
            }
        }
        public PortTCPClient()
        {
            type = 2;
        }
        private void TcpClient_ConnectedChanged(object sender, AsyncTCPClient.ConnctedChangedArg e)
        {
            ConnectedChangedEvent?.Invoke(sender, e);
        }

        private void TCP_DataRecv(byte[] vs, int len)
        {
            OnDataRec(null, this, vs);
        }

        public override bool Connected()
        {
            return tcpClient.IsConnected;
        }

        public override void write(byte[] b, IPEndPoint iP = null)
        {
            tcpClient?.Send(b);
        }

        public override void close()
        {
            tcpClient?.Stop();
        }

        public override void open()
        {
            tcpClient.Start();
        }
    }
    public class PortTCPService:PortBase
    {
        [JsonIgnore]
        AsyncSocketTCPServer tcpServer;

        public override void setParam(string ip,string port)
        {
            param1 = ip;
            param2 = port;
            IPAddress address;
            if(IPAddress.TryParse(ip,out address))
            {
                IPEndPoint localEP = new IPEndPoint(address,Convert.ToInt32(port));
                tcpServer = new AsyncSocketTCPServer(localEP);
                name = "service-" + localEP.ToString();
                tcpServer.DataReceived += TcpServer_DataReceived;
            }
        }

        private void TcpServer_DataReceived(object sender, AsyncSocketEventArgs e)
        {
            byte[] b = e._state.RecvDataBuffer.Take(e._state.recvLen).ToArray();
            OnDataRec(e._state.ClientSocket.RemoteEndPoint, this,b);
        }
        public PortTCPService()
        {
            type = 3;
        }
        public override bool Connected()
        {
            return tcpServer.IsRunning;
        }

        public override void write(byte[] b,IPEndPoint point = null)
        {
            if(point == null)
            {
                tcpServer.SendAll(b);
            }
            else
            {
                tcpServer.Send(tcpServer.clients[point], b);
            }
        }

        public override void close()
        {
            tcpServer?.Stop();
        }

        public override void open()
        {
            tcpServer?.Start();
        }
    }
    
}
