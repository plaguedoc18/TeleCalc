using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItUniver.TeleCalc.Core.Operations
{
    internal class Degr:IOperation
    {
        public string Name { get { return "degr"; } }
        public double[] Args
        {
            set
            {
                Result = value.Aggregate((x, y) => Math.Pow(x,y));                               
            }
            get { return new double[0]; } 
        }
        public string Error { get { return ""; } }
        public double? Result { get; private set; } 
    }
    

}
