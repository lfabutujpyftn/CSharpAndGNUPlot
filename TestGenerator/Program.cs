using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Generator gen = new Generator();
            gen.Filename = "test";
            gen.Start = -1000;
            gen.Finish = 1000;
            gen.Step = .1;
            gen.From = -30;
            gen.To = 30;
            gen.GenTest();
        }
    }
}
