using FDPort.Class;
using FDPort.Communication;
using FDPort.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FDPort.Class.AsyncTCPClient;

namespace FDPort.Forms
{
    public partial class NewPort : Form
    {
        UartMore um;
        PortSerial serial = new PortSerial();
        PortTCPClient client = new PortTCPClient();
        PortTCPService service = new PortTCPService();

        public delegate void PortOpenOkCb(PortBase port);
        public event PortOpenOkCb OnPortOpenOk;

        public NewPort()
        {
            InitializeComponent();

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
        }

        #region TCP客户端
        private void port_open(PortBase port)
        {
            if (Project.param.portForwarding != null)
            {
                Project.param.portForwarding.Close();
            }
            port.Open();

            if(port.Connected())
            {
                Project.param.portForwarding = port;
                Project.param.needForwarding = true;
                OnPortOpenOk(port);
                Close();
            }
            else
            {
                MessageBox.Show("连接失败");
            }
            
        }
        private void uiButton5_Click(object sender, EventArgs e)
        {
            try
            {
                client.SetParam(tcpCliIP.Text, tcpCliPort.Text);
                port_open(client);
            }
            catch (Exception exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }

        }

        #endregion

        #region TCP服务端
        private void uiButton3_Click(object sender, EventArgs e)
        {
            try
            {
                service.SetParam(serIP.Text, serPort.Text);
                port_open(service);
            }
            catch (Exception exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }
        }
        #endregion

        #region event

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                serial.SetParam(cmbPort.Text, baudCombo.Text);
                port_open(serial);
            }
            catch (Exception exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }
        }

        private void uart_more_Click_1(object sender, EventArgs e)
        {
            um = UartMore.GetInstance(serial.port);

            um.TopMost = true;
            um.TopMost = false;

            um.ShowDialog();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            serialPanel.Visible = true;
            socketCliPanel.Visible = false;
            socketSerPanel.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            serialPanel.Visible = false;
            socketCliPanel.Visible = true;
            socketSerPanel.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            serialPanel.Visible = false;
            socketCliPanel.Visible = false;
            socketSerPanel.Visible = true;
        }
        #endregion
    }
}
