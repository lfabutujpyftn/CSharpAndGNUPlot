using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plot
{
    public class Plot: IPlot
    {
        private Color color;
        private DrawType drawType;
        private string xTitle;
        private string yTitle;
        private string title;
        public Color Color 
        {
            get { return color;}
            set { color = value;}
        }

        public string XTitle
        {
            get { return xTitle; }
            set { xTitle = value; }
        }

        public string YTitle 
        {
            get { return yTitle; }
            set { yTitle = value; } 
        }

        public string Title 
        {
            get { return title; }
            set { title = value; }
        }

        public DrawType DrawType 
        {
            get { return drawType; }
            set { drawType = value; }
        }

        private string getParam()
        {
            AwokeKnowing.GnuplotCSharp.GnuPlot.Set("xlabel \"" + xTitle + "\"");
            AwokeKnowing.GnuplotCSharp.GnuPlot.Set("ylabel \"" + yTitle + "\"");
            string par = "using 1:2 title \"" + title + "\"";
            switch (drawType)
            {
                case DrawType.Lines:
                    par += " with lines";
                    break;
                case DrawType.Points:
                    par += " with points";
                    break;
                default:
                    break;
            }
            switch (color)
            {
                case Color.Blue:
                    par += " linecolor rgb \"blue\"";
                    break;
                case Color.Green:
                    par += " linecolor rgb \"green\"";
                    break;
                case Color.Black:
                    par += " linecolor rgb \"black\"";
                    break;
                case Color.Red:
                    par += " linecolor rgb \"red\"";
                    break;
                default:
                    break;
            }
            return par;
        }
        public void DrawFile(string filePath)
        {
            Console.WriteLine("Start draw file \"" + filePath + "\"");
            AwokeKnowing.GnuplotCSharp.GnuPlot.Plot("\"" + filePath + "\"", getParam());
            Console.WriteLine("End draw file \"" + filePath + "\"");
        }

        public void Close()
        {
            AwokeKnowing.GnuplotCSharp.GnuPlot.Close();
        }

        public void DrawPoints(IEnumerable<Point> points)
        {
            ArrayList arrPoints = new ArrayList();
            foreach (Point i in points)
            {
                arrPoints.Add(i);
            }
            var x = new double[arrPoints.Count];
            var y = new double[arrPoints.Count];
            for(int i = 0; i < arrPoints.Count; ++i)
            {
                x[i] = ((Point)(arrPoints[i])).X;
                y[i] = ((Point)(arrPoints[i])).Y;
            }
            AwokeKnowing.GnuplotCSharp.GnuPlot.Plot(x, y, getParam());
        }
    }
}
