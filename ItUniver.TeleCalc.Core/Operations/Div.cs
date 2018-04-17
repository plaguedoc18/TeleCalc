using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItUniver.TeleCalc.Core.Operations
{
    internal class Div:IOperation
    {
        public string Name { get { return "div"; } }
        public double[] Args
        {
            set
            {
                var div=value[0];
                for (int i=1; i < value.Length;i++ )
                { div = div / value[i]; }
                Result = div;                
            }
            get { return new double[0]; } 
        }
        public string Error { get { return ""; } }
        public double? Result { get; private set; } 
    }
    

}
