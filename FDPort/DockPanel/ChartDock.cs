using FDPort.Class;
using FDPort.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WeifenLuo.WinFormsUI.Docking;

namespace FDPort.DockPanel
{
    public partial class ChartDock : DockContent
    {
        #region publicFunc
        public ChartDock()
        {
            InitializeComponent();
            TabText = "曲线";
            CloseButton = false;
            CloseButtonVisible = false;
        }


        public void chart_init()
        {
            //option.ToolTip.Visible = true;
            //option.Title = null;
            //option.XAxis.AxisLabel.DecimalCount = 1;
            //option.XAxis.AxisLabel.AutoFormat = false;
            //option.YAxis.AxisLabel.DecimalCount = 1;
            //option.YAxis.AxisLabel.AutoFormat = false;
            //option.Grid.Bottom = 30;
            //option.Grid.Top = 30;
            //option.Grid.Left = 30;
            //option.Grid.Right = 30;
            //option.XAxis.Min = 0;
            //option.XAxis.Max = 220;
            //option.XAxis.MaxAuto = false;
            //option.XAxis.MinAuto = false;
            //LineChart.SetOption(option);
        }
        
        public void chart_add_series(string name)
        {
            if (LineChart.Series.IndexOf(name) < 0)
            {
                Series ser = new Series(name);
                ser.ChartType = SeriesChartType.Line;
                LineChart.Series.Add(ser);
            }
        }
        public void chart_del_series(string str)
        {
            if (LineChart.Series.IndexOf(str) >= 0)
            {
                Series series = LineChart.Series[str];
                LineChart.Series.Remove(series);
            }
        }
        public void chart_add_point(string str, decimal value)
        {
            if (LineChart.Series.IndexOf(str) >= 0)
            {
                chart_add_series(str);
            }
            Series series = LineChart.Series[str];
            if (series != null)
            {
                UIControl.AddSeriesPoint(LineChart, str, value);
            }
        }

        public void chart_clear()
        {
            foreach (Series series in LineChart.Series)
            {
                series.Points.Clear();
            }
            UIControl.SeriesClear();
            LineChart.ChartAreas[0].AxisX.Minimum = 0;
            LineChart.ChartAreas[0].AxisX.Maximum = 220;
            LineChart.Refresh();
        }
        #endregion
        #region event
        private void LineChart_MouseEnter(object sender, EventArgs e)
        {
            MouseWheel += new MouseEventHandler(chart1_MouseEnter);//调用滚轮事件
        }
        private void chart1_MouseEnter(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)//鼠标向上
            {
                if (UIControl.index > 200 && UIControl.index > UIControl.show)
                {
                    UIControl.show += 1;
                    LineChart.ChartAreas[0].AxisX.Maximum += 1;
                    LineChart.ChartAreas[0].AxisX.Minimum += 1;
                }
            }
            else//鼠标向下滚动
            {
                if (UIControl.index > 200 && UIControl.show > 200)
                {
                    UIControl.show -= 1;
                    LineChart.ChartAreas[0].AxisX.Maximum -= 1;
                    LineChart.ChartAreas[0].AxisX.Minimum -= 1;
                }
            }
            LineChart.Refresh();
        }

        private void 移至开始ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIControl.show = 0;
            LineChart.ChartAreas[0].AxisX.Minimum = 0;
            LineChart.ChartAreas[0].AxisX.Maximum = 220;
        }
        private void 移至最新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIControl.show = UIControl.index;
        }
        private void 缩小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LineChart.ZoomBack();
        }
        private void 正常大小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LineChart.ZoomNormal();
        }
        private void 清空图像ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart_clear();
        }
        #endregion
    }
}
