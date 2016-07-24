using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestGenerator
{
    public class Generator
    {
        private string filename;
        private int start;
        private int finish;
        private double step;
        private int from;
        private int to;

        public string Filename
        {
            get { return filename; }
            set { filename = value; }
        }
        public int Start
        {
            get { return start; }
            set { start = value; }
        }
        public int Finish
        {
            get { return finish; }
            set { finish = value; }
        }
        public double Step
        {
            get { return step; }
            set { step = value; }
        }
        public int From
        {
            get { return from; }
            set { from = value; }
        }
        public int To
        {
            get { return to; }
            set { to = value; }
        }

        public void genTest()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            FileStream file = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);
            Random rnd = new Random();
            for(double i = (double)start; i <= finish; i += step)
            {
                string arg = i.ToString("G") + "\t" + rnd.Next(from, to).ToString("G");
                writer.WriteLine(arg);
            }
            writer.Close();
        }
    }
}
