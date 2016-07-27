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
        private string _filename;
        private int _start;
        private int _finish;
        private double _step;
        private int _from;
        private int _to;

        public string Filename
        {
            get { return _filename; }
            set { _filename = value; }
        }
        public int Start
        {
            get { return _start; }
            set { _start = value; }
        }
        public int Finish
        {
            get { return _finish; }
            set { _finish = value; }
        }
        public double Step
        {
            get { return _step; }
            set { _step = value; }
        }
        public int From
        {
            get { return _from; }
            set { _from = value; }
        }
        public int To
        {
            get { return _to; }
            set { _to = value; }
        }

        public void GenTest()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            FileStream file = new FileStream(_filename, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);
            Random rnd = new Random();
            for(double i = (double)_start; i <= _finish; i += _step)
            {
                string arg = i.ToString("G") + "\t" + rnd.Next(_from, _to).ToString("G");
                writer.WriteLine(arg);
            }
            writer.Close();
        }
    }
}
