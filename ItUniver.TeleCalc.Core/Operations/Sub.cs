using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItUniver.TeleCalc.Core.Operations
{
    internal class Sub:IOperation
    {
        public string Name { get { return "sub"; } }
        public double[] Args
        {
            set
            {
                var sub = value[0];
                for (int i = 1; i < value.Length; i++)
                { sub = sub - value[i]; }
                Result = sub;                
            }
            get { return new double[0]; } 
        }
        public string Error { get { return ""; } }
        public double? Result { get; private set; } 
    }
    
    public class CalcTest
    {
        void Calc()
        {
            IOperation sum1 = new Sub();
        }
    }
}
