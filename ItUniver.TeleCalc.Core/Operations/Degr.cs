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
                var degr = 1d;
                for (int i = 1; i < value[2]; i++)
                { degr = degr * value[1]; }
                Result = degr;                  
            }
            get { return new double[0]; } 
        }
        public string Error { get { return ""; } }
        public double? Result { get; private set; } 
    }
    

}
