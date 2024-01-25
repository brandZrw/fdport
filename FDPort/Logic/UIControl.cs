

using FDPort.Class;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.Drawing;
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
                SetTextDelegate myDelegate = new SetTextDelegate(SetText);
                txtInfo.Invoke(myDelegate, txtInfo, value);
            }
            else
            {
                txtInfo.Text = (value);
            }
        }
        private delegate string GetTextDelegate(Control txtInfo);
        static public string GetText(Control txtInfo)
        {
            if (txtInfo == null)
            {
                return null;
            }
            if (txtInfo.InvokeRequired)//判断是否跨线程请求
            {
                GetTextDelegate myDelegate = new GetTextDelegate(GetText);
                return (string)txtInfo.Invoke(myDelegate, txtInfo);
            }
            else
            {
                return txtInfo.Text;
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
                AddTextBoxValueDelegate myDelegate = new AddTextBoxValueDelegate(AddTextBoxValue);
                txtInfo.Invoke(myDelegate, txtInfo, value);
            }
            else
            {
                txtInfo.AppendText(value);
            }
        }

        private delegate void AddRichTextBoxValueDelegate(RichTextBox txtInfo, string value, Color color);
        static public void AddRichTextBoxValue(RichTextBox txtInfo, string value, Color color)
        {
            if (txtInfo == null)
            {
                return;
            }
            if (txtInfo.InvokeRequired)//判断是否跨线程请求
            {
                AddRichTextBoxValueDelegate myDelegate = new AddRichTextBoxValueDelegate(AddRichTextBoxValue);
                txtInfo.Invoke(myDelegate, txtInfo, value, color);
            }
            else
            {
                txtInfo.SelectionColor = color;
                txtInfo.AppendText(value);
                txtInfo.ScrollToCaret();
            }

                
        }

        private delegate void ClearRichTextBoxValueDelegate(RichTextBox txtInfo);
        static public void ClearRichTextBoxValue(RichTextBox txtInfo)
        {
            if (txtInfo == null)
            {
                return;
            }
            if (txtInfo.InvokeRequired)//判断是否跨线程请求
            {
                ClearRichTextBoxValueDelegate myDelegate = new ClearRichTextBoxValueDelegate(ClearRichTextBoxValue);
                txtInfo.Invoke(myDelegate, txtInfo);
            }
            else
            {
                txtInfo.Text = "";
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
                ClearTextBoxValueDelegate myDelegate = new ClearTextBoxValueDelegate(ClearTextBoxValue);
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
        public delegate void SeriesAddPointDelegate(FormsPlot a, Dictionary<string, PlotPoints>plot, string x, decimal value);
        static public void AddSeriesPoint(FormsPlot a, Dictionary<string, PlotPoints>plot, string x, decimal value)
        {
            if (a == null)
            {
                return;
            }
            if (a.InvokeRequired)//判断是否跨线程请求
            {
                SeriesAddPointDelegate myDelegate = new SeriesAddPointDelegate(AddSeriesPoint);
                a.Invoke(myDelegate, a,plot, x, value);
            }
            else
            {
                plot[x].AddPoint(plot[x].Count, Decimal.ToDouble(value));
                double max = int.MinValue;
                double min = int.MaxValue;
                
                foreach(PlotPoints p in plot.Values)
                {
                    if(max < p.max)
                    {
                        max = p.max;
                    }
                    if(min > p.min)
                    {
                        min = p.min;
                    }
                }
                if (min >= max)
                {
                    min = max - 1;
                }
                a.Plot.YAxis.SetBoundary(min: min, max: max);

                if (plot[x].Count < PlotPoints.maxPointShow)
                {
                    a.Plot.XAxis.SetBoundary(min: PlotPoints.maxPointShow - plot[x].Count-1, max: PlotPoints.maxPointShow);
                }
                else
                {
                    a.Plot.XAxis.SetBoundary(min: 0, max: PlotPoints.maxPointShow);
                }

                a.Refresh();
            }
        }
    }
}
