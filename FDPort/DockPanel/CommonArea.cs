using FDPort.Class;
using FDPort.Communication;
using FDPort.Forms;
using FDPort.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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

            Project.mainForm.dataRec.dataDealFunc += recData;

            client.ConnectedChangedEvent += TcpClient_ConnectedChanged;

            // 数据绑定

            cmbPort.DataBindings.Add("Text", Project.param, "com");
            baudCombo.DataBindings.Add("Text", Project.param, "baud");
            tcpTimeout.DataBindings.Add("Text", Project.param, "timeout");
            tcpCliIP.DataBindings.Add("Text", Project.param, "cIP");
            tcpCliPort.DataBindings.Add("Text", Project.param, "cPort");
            serIP.DataBindings.Add("Text", Project.param, "sIP");
            serPort.DataBindings.Add("Text", Project.param, "sPort");
            recBox.textBox.ReadOnly = true;
            Project.param.portNow = serial;
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
            tcpTimeout.Text = Project.param.timeout;
            tcpCliIP.Text = Project.param.cIP;
            tcpCliPort.Text = Project.param.cPort;
            serIP.Text = Project.param.sIP;
            serPort.Text = Project.param.sPort;
        }

        public void close()
        {
            service.close();
            client.close();
            serial.close();
            button1.Text = "打开串口";
            uiButton3.Text = "侦听";
            uiButton5.Text = "连接";
        }
        #endregion

        #region 数据交换


        void writeFile(string data)
        {
            sw.Write(data);
        }
        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="vs"></param>
        public void sendData(byte[] vs,PortBase port)
        {

            port?.write(vs);
            

            string bs = common.byteArrayToString(vs, vs.Length);
            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrEmpty(UIControl.GetText(recBox.textBox)))
            {
                sb.AppendLine();
            }
            if (Project.param.addTimestamp) // 启用时间戳
            {
                sb.Append(DateTime.Now.ToString("HH:mm:ss.fff"));
            }
            sb.Append("发:");
            sb.Append(bs);
            
            UIControl.AddRichTextBoxValue(recBox.textBox, sb.ToString(),Color.Black);//发送窗口显示
            if (needSave)
            {
                writeFile(sb.ToString());
            }

        }
        private int recData(PortBase from,byte[] vs, int len)
        {
            string bs = common.byteArrayToString(vs, len);
            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrEmpty(UIControl.GetText(recBox.textBox)))
            {
                sb.AppendLine();
            }
            if (Project.param.addTimestamp)
            {
                sb.Append(DateTime.Now.ToString("HH:mm:ss.fff"));
            }
            sb.Append("收:");
            sb.Append(bs);
            UIControl.AddRichTextBoxValue(recBox.textBox, sb.ToString(),Color.Green);
            if (needSave)
            {
               writeFile(sb.ToString());
            }

            return Project.mainForm.parse.dataParsing(from,vs, len);

        }

        #endregion

        #region event
        private void sendBox_ButtonClick(object sender, EventArgs e)
        {
            string hex = sendBox.textBox.Text.Trim(' ');
            if (string.IsNullOrEmpty(hex))
            {
                return;
            }
            string[] hexarray = hex.Split(' ');
            List<byte> bs = new List<byte>();
            try
            {
                foreach (string a in hexarray)
                {
                    bs.Add(Convert.ToByte(a, 16));
                }
                sendData(bs.ToArray(),Project.param.needForwrding?Project.param.portForwarding:Project.param.portNow);
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

        /// <summary>
        /// 超时时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tcpTimeout_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tcpTimeout.Text))
            {
                return;
            }
            uint temp = 20;
            if(UInt32.TryParse(tcpTimeout.Text,out temp))
            {
                Project.mainForm.dataRec.set_timeout(temp);
            }
        }
        #endregion

        #region 串口相关
        public void FreshComList()
        {
            string selectStr = cmbPort.Text;
            string[] str = common.GetComList();
            cmbPort.Items.Clear();
            for (int i = 0; i < str.Length; i++)
            {
                cmbPort.Items.Add(str[i]);
            }
            if (cmbPort.Items.Contains(selectStr) == false)
            {
                if (cmbPort.Items.Count > 0)
                {
                    cmbPort.SelectedIndex = 0;
                }
                else
                {
                    cmbPort.SelectedIndex = -1;
                }
            }
            else
            {
                cmbPort.Text = selectStr;
            }
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

                serial.close();
            }
            else
            {
                try
                {
                    serial.setParam(cmbPort.Text, baudCombo.Text);
                    serial.open();
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
                    client.setParam(tcpCliIP.Text, tcpCliPort.Text);
                    client.open();  
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
                    client.close();
                }
            }
        }


        private void TcpClient_ConnectedChanged(object sender, ConnctedChangedArg e)
        {
            if (e.Connected)
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
                    service.setParam(serIP.Text, serPort.Text);

                    service.open();
                    uiButton3.Text = "断开";
                }
                else if (uiButton3.Text.Equals("断开"))
                {
                    //
                    if (service != null)
                    {
                        service.close();
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
