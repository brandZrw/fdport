using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FDPort.Forms
{
    public partial class UartMore : System.Windows.Forms.Form
    {
        SerialPort serial;
        public UartMore(SerialPort serial)
        {
            InitializeComponent();
            this.serial = serial;
            dataBits.SelectedIndex = 8 - serial.DataBits;
            switch (serial.StopBits)
            {
                case StopBits.One:
                    stopBits.SelectedIndex = 0;
                    break;
                case StopBits.OnePointFive:
                    stopBits.SelectedIndex = 1;
                    break;
                case StopBits.Two:
                    stopBits.SelectedIndex = 2;
                    break;
            }
            switch (serial.Parity)
            {
                case Parity.None:
                    parity.SelectedIndex = 0;
                    break;
                case Parity.Odd:
                    parity.SelectedIndex = 1;
                    break;
                case Parity.Even:
                    parity.SelectedIndex = 2;
                    break;
                case Parity.Mark:
                    parity.SelectedIndex = 3;
                    break;
                case Parity.Space:
                    parity.SelectedIndex = 4;
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            serial.DataBits = 8 - dataBits.SelectedIndex;
            switch (stopBits.SelectedIndex)
            {
                case 0:
                    serial.StopBits = StopBits.One;
                    break;
                case 1:
                    serial.StopBits = StopBits.OnePointFive;
                    break;
                case 2:
                    serial.StopBits = StopBits.Two;
                    break;
            }
            switch (parity.SelectedIndex)
            {
                case 0:
                    serial.Parity = Parity.None;
                    break;
                case 1:
                    serial.Parity = Parity.Odd;
                    break;
                case 2:
                    serial.Parity = Parity.Even;
                    break;
                case 3:
                    serial.Parity = Parity.Mark;
                    break;
                case 4:
                    serial.Parity = Parity.Space;
                    break;
            }
            this.Close();
        }
    }
}
