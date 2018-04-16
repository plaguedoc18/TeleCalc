using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItUniver.TeleCalc.ConCalc
{
    public class Calc
    {
        public Double Sum(Double x, Double y)
        {
            return x+y;
        }
        public Double Sub(Double x, Double y)
        {
            return x - y;
        }
        public Double Mult(Double x, Double y)
        {
            return x * y;
        }
        public Double Cube(Double x)
        {
            return x * x * x;
        }
        public Double Div(Double x, Double y)
        {
            return x / y;
        }
    }
}
