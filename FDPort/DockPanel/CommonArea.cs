using FDPort.Class;
using FDPort.Communication;
using FDPort.Forms;
using FDPort.Logic;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using static FDPort.Class.AsyncTCPClient;

namespace FDPort.DockPanel
{
    public partial class CommonArea : DockContent
    {

        public StreamWriter sw;
        UartMore um;
        public bool needSave = false; // 是否需要保存数据
        private ThreadQueue<CmdSendQueueObj> sendThread;
        private ThreadQueue<RecBoxUpdate> recBoxThread;
        static USB USBWatcher = new USB();

        PortSerial serial = new PortSerial();
        PortTCPClient client = new PortTCPClient();
        PortTCPService service = new PortTCPService();
        
        #region public
        public CommonArea()
        {
            InitializeComponent();
            TabText = "收发配置";
            CloseButton = false;
            CloseButtonVisible = false;
            string[] str = common.GetComList();
            cmbPort.Items.Clear();
            for (int i = 0; i < str.Length; i++)
            {
                cmbPort.Items.Add(str[i]);
            }
            if (cmbPort.Items.Count > 0)
            {
                cmbPort.SelectedIndex = 0;
            }
            baudCombo.SelectedIndex = 3;

            Project.mainForm.dataRec.dataDealFunc = new DataRec.DataDealCb(RecDataDeal);
            Project.mainForm.dataRec.dataRecFunc = new DataRec.DataRecCb(RecData);

            client.ConnectedChangedEvent += TcpClient_ConnectedChanged;

            // 数据绑定

            //cmbPort.DataBindings.Add("Text", Project.param, "com");
            //baudCombo.DataBindings.Add("Text", Project.param, "baud");
            //tcpTimeout.DataBindings.Add("Text", Project.param, "timeout");
            //tcpCliIP.DataBindings.Add("Text", Project.param, "cIP");
            //tcpCliPort.DataBindings.Add("Text", Project.param, "cPort");
            //serIP.DataBindings.Add("Text", Project.param, "sIP");
            //serPort.DataBindings.Add("Text", Project.param, "sPort");
            recBox.textBox.ReadOnly = true;
            Project.param.portNow = serial;

            USBWatcher.AddUSBEventWatcher(USBEventHandler, USBEventHandler, new TimeSpan(0, 0, 1));
            sendThread = new ThreadQueue<CmdSendQueueObj>(SendThread);
            recBoxThread = new ThreadQueue<RecBoxUpdate>(RecBoxUpdateThread);
        }
        public class RecBoxUpdate
        {
            public byte[] vs;
            public bool isRec;
            public RecBoxUpdate(byte[] a, bool rec)
            {
                vs = a;
                isRec = rec;
            }
        }
        public void ShowCommType(int type)
        {
            switch (type)
            {
                case 0:
                    serialPanel.Visible = true;
                    socketSerPanel.Visible = false;
                    socketCliPanel.Visible = false;
                    Project.param.portNow = serial;
                    break;
                case 1:
                    serialPanel.Visible = false;
                    socketSerPanel.Visible = true;
                    socketCliPanel.Visible = false;
                    Project.param.portNow = service;
                    break;
                case 2:
                    serialPanel.Visible = false;
                    socketSerPanel.Visible = false;
                    socketCliPanel.Visible = true;
                    Project.param.portNow = client;
                    break;
            }

        }
        public void AreaTextFresh()
        {
            cmbPort.Text = Project.param.com;
            baudCombo.Text = Project.param.baud;
            tcpCliIP.Text = Project.param.cIP;
            tcpCliPort.Text = Project.param.cPort;
            serIP.Text = Project.param.sIP;
            serPort.Text = Project.param.sPort;
        }

        public void AddSendCmd(CmdSendQueueObj obj)
        {
            sendThread.Add(obj);
        }

        public void AddRecBoxText(byte[] vs,bool isRec)
        {
            recBoxThread.Add(new RecBoxUpdate(vs, isRec));
        }
        /// <summary>
        /// 关闭发送队列
        /// </summary>
        public void CloseSend()
        {
            recBoxThread.Close();
            sendThread.Close();
        }

        /// <summary>
        /// 关闭端口
        /// </summary>
        public void ClosePort()
        {
            service.Close();
            client.Close();
            serial.Close();
            button1.Text = "打开串口";
            uiButton3.Text = "侦听";
            uiButton5.Text = "连接";
        }
        #endregion

        #region 数据交换

        void SendThread(CmdSendQueueObj item)
        {
            item.cmd.SendDo(item.port, item.point);
        }
        void WriteFile(string data)
        {
            sw.Write(data);
        }
        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="vs"></param>
        public void SendData(byte[] vs,PortBase port,IPEndPoint point = null)
        {
            port?.Write(vs, point);

            AddRecBoxText(vs, false);
        }

        private int RecData(PortBase from, byte[] vs, int len, IPEndPoint point)
        {
            AddRecBoxText(vs, true);
            return 0;
        }
        private int RecDataDeal(PortBase from,byte[] vs, int len,IPEndPoint point)
        {
            if(len == 0)
            {
                return 0;
            }

            return Project.mainForm.parse.dataParsing(from,vs, len, point);

        }

        #endregion

        #region event

        void RecBoxUpdateThread(RecBoxUpdate item)
        {
            string bs = common.ByteArrayToString(item.vs, item.vs.Length);
            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrEmpty(UIControl.GetText(recBox.textBox)))
            {
                sb.AppendLine();
            }
            if (Project.param.addTimestamp) // 启用时间戳
            {
                sb.Append(DateTime.Now.ToString("HH:mm:ss.fff "));
            }
            if (item.isRec)///接收更新
            {
                sb.Append("收:");
                sb.Append(bs);
                UIControl.AddRichTextBoxValue(recBox.textBox, sb.ToString(), Color.Green);
                if (needSave)
                {
                    WriteFile(sb.ToString());
                }
            }
            else
            {
                   
                sb.Append("发:");
                sb.Append(bs);

                UIControl.AddRichTextBoxValue(recBox.textBox, sb.ToString(), Color.Black);//发送窗口显示
                if (needSave)
                {
                    WriteFile(sb.ToString());
                }
            }
            
        }
        private void sendBox_ButtonClick(object sender, EventArgs e)
        {
            string hex = sendBox.textBox.Text.Trim(' ');
            if (string.IsNullOrEmpty(hex))
            {
                return;
            }
            string[] hexArray = hex.Split(' ');
            List<byte> bs = new List<byte>();
            try
            {
                foreach (string a in hexArray)
                {
                    char[] ch = a.ToCharArray();
                    StringBuilder sb = new StringBuilder();
                    foreach(char c in ch)
                    {
                        sb.Append(c);
                        if(sb.Length >= 2)
                        {
                            bs.Add(Convert.ToByte(sb.ToString(), 16));
                            sb.Clear();
                        }
                    }
                    if(sb.Length > 0)
                    {
                        bs.Add(Convert.ToByte(sb.ToString(), 16));
                    }
                    
                }
                SendData(bs.ToArray(),Project.param.needForwarding?Project.param.portForwarding:Project.param.portNow);
            }
            catch (Exception exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }
        }

        private void recBox_ButtonClick(object sender, EventArgs e)
        {
            UIControl.ClearRichTextBoxValue(recBox.textBox);
        }
        #endregion

        #region 串口相关

        private void USBEventHandler(Object sender, EventArrivedEventArgs e)
        {
            //暂未实现
            var watcher = sender as ManagementEventWatcher;
            watcher.Stop();
            //刷新设备信息
            //RefreshDevice();
            if (e.NewEvent.ClassPath.ClassName == "__InstanceCreationEvent")
            {

                FreshComList();

                //  m_notificationWindowApp.AddNotification((string)this.TryFindResource("USBDeviceTips"), (string)this.TryFindResource("NewUSBDevice"));
            }
            else if (e.NewEvent.ClassPath.ClassName == "__InstanceDeletionEvent")
            {

                FreshComList();
                Console.WriteLine("USB 设备拔出 \n");
                Console.WriteLine("关闭串口  +++++ \n");
                //_serialPort.Close();

                // _serialPort.Open()

                // _serialPort.Close();


                //m_notificationWindowApp.AddNotification((string)this.TryFindResource("USBDeviceTips"), (string)this.TryFindResource("USBDeviceDisconnected"));
            }
            //Default_USBConnctionObj();
            /// Toolbar_AvailableCheck();
            // 业务代码，逻辑耗时尽量不要太长，以免影响事件的监听
            watcher.Start();
        }

        public void FreshComList()
        {
            string[] str = common.GetComList();
            UIControl.FreshCom(cmbPort,str);
        }
        private void cmbPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            Project.param.com = cmbPort.Text;
        }

        private void baudCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Project.param.baud = baudCombo.Text;
        }
        
        private void uart_more_Click(object sender, EventArgs e)
        {
            um = UartMore.GetInstance(serial.port);

            um.TopMost = true;
            um.TopMost = false;

            um.ShowDialog();
        }
        
      
        private void button1_Click(object sender, EventArgs e)
        {
            if(serial != null && serial.Connected())
            {
                cmbPort.Enabled = true;
                baudCombo.Enabled = true;
                button1.Text = "打开串口";

                serial.Close();
            }
            else
            {
                try
                {
                    serial.SetParam(cmbPort.Text, baudCombo.Text);
                    serial.Open();
                    cmbPort.Enabled = false;
                    baudCombo.Enabled = false;
                    button1.Text = "关闭串口";
                }
                catch (Exception exp)
                {
                    System.Windows.Forms.MessageBox.Show(exp.Message);
                }

            }
        }
        #endregion

        #region TCP客户端
        
        private void uiButton5_Click(object sender, EventArgs e)
        {
            if (uiButton5.Text.Equals("连接"))
            {
                try
                {
                    client.SetParam(tcpCliIP.Text, tcpCliPort.Text);
                    client.Open();  
                }
                catch (Exception exp)
                {
                    System.Windows.Forms.MessageBox.Show(exp.Message);
                }
            }
            else
            {
                if (client != null)
                {
                    client.Close();
                }
            }
        }


        private void TcpClient_ConnectedChanged(object sender, ConnectedChangedArg e)
        {
            if (e.connected)
            {
                UIControl.SetText(uiButton5, "断开");
            }
            else
            {
                UIControl.SetText(uiButton5, "连接");
            }
        }

       
        #endregion

        #region TCP服务端
        private void uiButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (uiButton3.Text.Equals("侦听"))
                {
                    service.SetParam(serIP.Text, serPort.Text);

                    service.Open();
                    uiButton3.Text = "断开";
                }
                else if (uiButton3.Text.Equals("断开"))
                {
                    //
                    if (service != null)
                    {
                        service.Close();
                    }
                    uiButton3.Text = "侦听";
                }
            }
            catch (Exception exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }
        }

        #endregion
    }
}
