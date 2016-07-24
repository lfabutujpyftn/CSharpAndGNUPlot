using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plot
{
    class Program
    {
        static void Main(string[] args)
        {
            Plot x = new Plot();
            x.XTitle = "xOxis";
            x.YTitle = "yOxis";
            x.Title = "parabola";
            x.DrawType = DrawType.Lines;
            x.Color = Color.Green;
            x.DrawFile("./test");
            /*ArrayList arr = new ArrayList();
            arr.Add(new Point(1, 2));
            arr.Add(new Point(2, 6));
            arr.Add(new Point(3, -4));
            arr.Add(new Point(4, 0));

            x.DrawPoints((IEnumerable) arr);*/

            Console.ReadKey();
        }
    }
}
