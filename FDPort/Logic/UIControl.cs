
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace FDPort.Logic
{
    class UIControl
    {
        private delegate void SetTextDelegate(Control txtInfo, string value);
        static public void SetText(Control txtInfo, string value)
        {
            if (txtInfo == null)
            {
                return;
            }
            if (txtInfo.InvokeRequired)//判断是否跨线程请求
            {
                SetTextDelegate myDelegate = delegate(Control txt, string text)
                {
                    txt.Text = (text);
                };
                txtInfo.Invoke(myDelegate, txtInfo, value);
            }
            else
            {
                txtInfo.Text = (value);
            }
        }
        private delegate void AddTextBoxValueDelegate(TextBox txtInfo, string value);
        static public void AddTextBoxValue(TextBox txtInfo, string value)
        {
            if (txtInfo == null)
            {
                return;
            }
            if (txtInfo.InvokeRequired)//判断是否跨线程请求
            {
                AddTextBoxValueDelegate myDelegate = delegate(TextBox txt, string text)
                {
                    txt.AppendText(text);
                };
                txtInfo.Invoke(myDelegate, txtInfo, value);
            }
            else
            {
                txtInfo.AppendText(value);
            }
        }

        private delegate void ClearTextBoxValueDelegate(TextBox txtInfo);
        static public void ClearTextBoxValue(TextBox txtInfo)
        {
            if (txtInfo == null)
            {
                return;
            }
            if (txtInfo.InvokeRequired)//判断是否跨线程请求
            {
                ClearTextBoxValueDelegate myDelegate = delegate(TextBox txt)
                {
                    txt.Text = "";
                };
                txtInfo.Invoke(myDelegate, txtInfo);
            }
            else
            {
                txtInfo.Text = "";
            }
        }
        public static int index = 0;
        public static int show = 0;
        static public void SeriesClear()
        {
            index = 0;
            show = 0;
        }

        static void SetXAxisShowLen(Chart txtInfo, int show)
        {
            txtInfo.ChartAreas[0].AxisX.Maximum = show + 20;
            txtInfo.ChartAreas[0].AxisX.Minimum = show - 200;
        }
        public delegate void SeriesAddPointDelegate(Chart txtInfo, string x, decimal value);
        static public void AddSeriesPoint(Chart txtInfo, string x, decimal value)
        {
            if (txtInfo == null)
            {
                return;
            }
            if (txtInfo.InvokeRequired)//判断是否跨线程请求
            {
                SeriesAddPointDelegate myDelegate = delegate(Chart a, string b, decimal c)
                {


                    if (index < a.Series[b].Points.Count + 1)
                    {
                        a.Series[b].Points.AddXY(index + 1, Decimal.ToDouble(c));
                        index = a.Series[b].Points.Count;
                        if (index > 200)
                        {
                            if (index <= show + 20)
                            {
                                SetXAxisShowLen(txtInfo, show);
                                show++;
                            }
                        }
                        else if (index == 200)
                        {
                            show = 200;
                            SetXAxisShowLen(txtInfo, show);

                        }
                    }
                    else
                    {
                        a.Series[b].Points.AddXY(index, Decimal.ToDouble(c));
                    }


                    txtInfo.Refresh();
                };
                txtInfo.Invoke(myDelegate, txtInfo, x, value);
            }
            else
            {
                index++;
                if (index > 200)
                {
                    SetXAxisShowLen(txtInfo, show);
                }
                txtInfo.Series[x].Points.AddXY(index, Decimal.ToDouble(value));
                txtInfo.Refresh();
            }
        }
    }
}
