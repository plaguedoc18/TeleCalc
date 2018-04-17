using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItUniver.TeleCalc.Core.Operations
{
    internal class Sum:IOperation
    {
        public string Name { get { return "sum"; } }
        public double[] Args
        {
            set
            {
                var sum=0d;
                foreach (var item in value)
                { sum = sum + item; }
                Result = sum;                
            }
            get { return new double[0]; } 
        }
        public string Error { get { return ""; } }
        public double? Result { get; private set; } 
    }
    

}
