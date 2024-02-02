using FDPort.Class;
using FDPort.Logic;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace FDPort.DockPanel
{
    public partial class ChartDock : DockContent
    {
        
        public Dictionary<string,PlotPoints> plotData { get; set; }
        
        #region publicFunc

        public ChartDock()
        {
            InitializeComponent();
            plotData = new Dictionary<string, PlotPoints>();
            TabText = "曲线";
            CloseButton = false;
            CloseButtonVisible = false;
            double[] xs1 = ScottPlot.DataGen.RandomWalk(2000);
            double[] ys1 = ScottPlot.DataGen.RandomWalk(2000);
            lineChart.Reset();
            lineChart.Plot.AddScatter(xs1, ys1);
            ChartInit();
            lineChart.Refresh();
        }

        private void LineChart_RightClicked(object sender, EventArgs e)
        {
            bool legendHasItems =  lineChart.Plot.GetPlottables()
                .Where(x => x.GetLegendItems() != null)
                .SelectMany(x => x.GetLegendItems())
                .Where(x => !string.IsNullOrEmpty(x.label))
                .Any();
            var legend = lineChart.Plot.Legend(enable: null, location: null);
            bool legendIsNotDetachedAlready = legend.IsDetached == false;
            detachLegendMenuItem.Visible = legendHasItems && legendIsNotDetachedAlready;
            plotObjectEditorToolStripMenuItem.Visible = lineChart.Configuration.EnablePlotObjectEditor;
            DefaultRightClickMenu.Show(System.Windows.Forms.Cursor.Position);
        }

        public void ChartInit()
        {
            lineChart.RightClicked -= lineChart.DefaultRightClickEvent;
            lineChart.RightClicked += LineChart_RightClicked;
            lineChart.Plot.XAxis.Ticks(false);
            lineChart.Plot.XAxis.Line(false);
            lineChart.Plot.YAxis.Line(false);
            lineChart.Plot.YAxis2.Line(false);
            lineChart.Configuration.AltLeftClickDragZoom = false;
            lineChart.Configuration.DoubleClickBenchmark = false;

            lineChart.Plot.SetAxisLimitsX(xMin: PlotPoints.maxPointShow - PlotPoints.pointShowNum, xMax: PlotPoints.maxPointShow);
        }
        
        public void ChartAddSeries(string name)
        {
            if(!plotData.ContainsKey(name))
            {
                plotData.Add(name, new PlotPoints());
                plotData[name].signalPlot = lineChart.Plot.AddSignal(plotData[name].ys, 1,null,label:name);
            }
            else
            {
                if(plotData[name].signalPlot == null)
                {
                    plotData[name].signalPlot = lineChart.Plot.AddSignal(plotData[name].ys, 1, null, label: name);
                }
                plotData[name].signalPlot.IsVisible = true;
            }
        }
        public void ChartDelSeries(string str)
        {
            if(plotData.ContainsKey(str))
            {
                plotData[str].signalPlot.IsVisible = false;
            }
        }
        public void ChartAddPoint(string str, decimal value)
        {
            ChartAddSeries(str);
            UIControl.AddSeriesPoint(lineChart, plotData,str,value);
            
        }

        public void ChartClear()
        {
            foreach(PlotPoints plot in plotData.Values)
            {
                plot.Clear();
                plot.signalPlot = null;
            }
            lineChart.Reset();
            UIControl.SeriesClear();
            ChartInit();
            
            lineChart.Refresh();
            //lineChart.ChartAreas[0].AxisX.Minimum = 0;
            //lineChart.ChartAreas[0].AxisX.Maximum = 220;
            //lineChart.Refresh();
        }
        #endregion
        #region event

     
        private void 清空图像ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChartClear();
        }

        private void copyMenuItem_Click(object sender, EventArgs e) => Clipboard.SetImage(lineChart.Plot.Render());
        private void RightClickMenu_Copy_Click(object sender, EventArgs e) => Clipboard.SetImage(lineChart.Plot.Render());
        private void RightClickMenu_Help_Click(object sender, EventArgs e) => new FormHelp().Show();
        private void RightClickMenu_AutoAxis_Click(object sender, EventArgs e) { lineChart.Plot.AxisAuto(); Refresh(); }
        private void RightClickMenu_OpenInNewWindow_Click(object sender, EventArgs e) => new FormsPlotViewer(lineChart.Plot).Show();
        private void RightClickMenu_DetachLegend_Click(object sender, EventArgs e) => new FormsPlotLegendViewer(lineChart).Show();
        private void RightClickMenu_SaveImage_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog
            {
                FileName = "ScottPlot.png",
                Filter = "PNG Files (*.png)|*.png;*.png" +
                         "|JPG Files (*.jpg, *.jpeg)|*.jpg;*.jpeg" +
                         "|BMP Files (*.bmp)|*.bmp;*.bmp" +
                         "|All files (*.*)|*.*"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
                lineChart.Plot.SaveFig(sfd.FileName);
        }
        private void RightClickMenu_PlotObjectEditor_Click(object sender, EventArgs e) => new PlotObjectEditor(lineChart).ShowDialog();
        #endregion
        public double Euclidean(double dx1, double dy1, double dx2, double dy2)
        {
            double dx = Math.Pow(dx1 - dx2, 2);
            double dy = Math.Pow(dy1 - dy2, 2);
            double Euclideanres = dx + dy;
            return Euclideanres;
        }
        private void lineChart_MouseMove(object sender, MouseEventArgs e)
        {
            // determine point nearest the cursor
            (double mouseCoordX, double mouseCoordY) = lineChart.GetMouseCoordinates();
            
            double pointY = 0;
            double distence = double.MaxValue;
            Point mouseLocation = e.Location;
            string name="";
            foreach (KeyValuePair<string, PlotPoints> points in plotData)
            {
                if(points.Value.signalPlot !=null)
                {
                    (double X, double Y, int Index) = points.Value.signalPlot.GetPointNearestX(mouseCoordX);
                    (float xPixel, float yPiexel) = lineChart.Plot.GetPixel(X, Y);
                    double di = Euclidean(xPixel, yPiexel, e.X, e.Y);
                    
                    if (di < distence)
                    {
                        distence = di;
                        pointY = Y;
                        name = points.Key;
                    }
                }
                
            }
            if(distence < 160)
            {
                mouseLocation.Y += label1.Height;
                mouseLocation.X += 16;
                label1.Location = mouseLocation;
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
            }
            // update the GUI to describe the highlighted point
            label1.Text = $"{name}:{pointY:N2}";
        }
    }
}
