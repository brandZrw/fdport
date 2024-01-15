using FDPort.Class;
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
        }

        public string name { get; set; }
    }

    public class PortSerial : PortBase
    {
        public SerialPort port;
        public void SetPort(string com, int baud)
        {
            port.PortName = com;
            port.BaudRate = baud;
            name = "serial-" + com + ":" + baud.ToString();
        }
        public PortSerial()
        {
            port = new SerialPort();
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
                OnDataRec(this,this,vs);
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

    public class PortTCPService:PortBase
    {
        AsyncSocketTCPServer tcpServer;

        public void SetIP(IPEndPoint localEP)
        {
            tcpServer = new AsyncSocketTCPServer(localEP);
            name = "service-" + localEP.ToString();
            tcpServer.DataReceived += TcpServer_DataReceived;
        }

        private void TcpServer_DataReceived(object sender, AsyncSocketEventArgs e)
        {
            byte[] b = e._state.RecvDataBuffer.Take(e._state.recvLen).ToArray();
            OnDataRec(this,this,b);
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
    public class PortTCPClient : PortBase
    {
        AsyncTCPClient tcpClient;

        public delegate void ConnectedChangedHandler(object sender, AsyncTCPClient.ConnctedChangedArg e);
        public event ConnectedChangedHandler ConnectedChangedEvent;

        public void SetIP(IPAddress iP, int port)
        {
            tcpClient = new AsyncTCPClient(iP,  port);
            name = "client-"+iP.ToString()+":" + port.ToString();
            tcpClient.dataReceived += TCP_DataRecv;
            tcpClient.ConnectedChanged += TcpClient_ConnectedChanged;
        }

        private void TcpClient_ConnectedChanged(object sender, AsyncTCPClient.ConnctedChangedArg e)
        {
            ConnectedChangedEvent?.Invoke(sender, e);
        }

        private void TCP_DataRecv(byte[] vs, int len)
        {
            OnDataRec(this,this,vs);
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
}
