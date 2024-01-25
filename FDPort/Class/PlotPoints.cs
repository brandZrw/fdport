using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDPort.Class
{
    public class PlotPoints
    {
        public static int maxPointShow = 8192;
        public static int pointShowNum = 220;
        public ScottPlot.Plottable.SignalPlot signalPlot { get; set; }
        public double max = double.MinValue;
        public double min = double.MaxValue;
        public double this[int index]
        {
            get { return points.ContainsKey(index) ? points[index] : 0; }
            set
            {
                if (points.ContainsKey(index))
                {
                    points[index] = value;
                }
            }
        }
        public double[] ys = new double[maxPointShow];
        public int Count { get { return points.Count; } }
        public Dictionary<int, double> points;
        public PlotPoints()
        {
            points = new Dictionary<int, double>();
        }
        public void AddPoint(int x, double y)
        {
            if (points.ContainsKey(x))
            {
                points[x] = y;
            }
            else
            {
                points.Add(x, y);
            }

            Array.Copy(ys, 1, ys, 0, ys.Length - 1);
            ys[8191] = y;
            if(y<min)
            {
                min = y;
            }
            if(y >max)
            {
                max = y;
            }
        }
        
        public void Clear()
        {
            points.Clear();
            Array.Clear(ys, 0, ys.Length);
        }

    }
}
