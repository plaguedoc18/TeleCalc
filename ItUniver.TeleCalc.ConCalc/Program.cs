using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItUniver.TeleCalc.ConCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calc();
            Double res;
            switch (args[0])
            {
                case "sum":
                    res=calc.Sum(Convert.ToDouble(args[1]), Convert.ToDouble(args[2]));
                    Console.WriteLine("="+res);
                    break;
                case "sub":
                    res=calc.Sub(Convert.ToDouble(args[1]), Convert.ToDouble(args[2]));
                    Console.WriteLine("="+res);
                    break;
                case "mult":
                    res=calc.Mult(Convert.ToDouble(args[1]), Convert.ToDouble(args[2]));
                    Console.WriteLine("="+res);
                    break;
                case "cube":
                    res=calc.Cube(Convert.ToDouble(args[1]));
                    Console.WriteLine("="+res);
                    break;
                case "div":
                    res=calc.Div(Convert.ToDouble(args[1]), Convert.ToDouble(args[2]));
                    Console.WriteLine("="+res);
                    break;
            }
        }
    }
}
