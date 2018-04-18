using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItUniver.TeleCalc.Core.Operations;
using System.Reflection;


namespace ItUniver.TeleCalc.Core
{
    public class Calc
    {
        private IOperation[] operations { get; set; }
        private String[] opernames { get; set; }
        public string[] GetOpers { get { return opernames; } }

        public Calc()
        {
            var opers = new List<IOperation>();
            var opernamesi = new List<String>();
            //получить теущую сборку
            
            var assembly = Assembly.GetExecutingAssembly();
            var classes = assembly.GetTypes(); //получить типы в ней

            foreach (var Item in classes)
            {
                //получаем котоорые находятся в классе
                var interfaces = Item.GetInterfaces();
                var IsOperation = interfaces.Any(i => i == typeof(IOperation));

                if (IsOperation)
                {
                    var obj = System.Activator.CreateInstance(Item) as IOperation;
                    if (obj!=null)
                    {
                        opers.Add(obj);
                    }
                    Console.WriteLine(Item.Name);
                    opernamesi.Add(Item.Name);
                }
            }

            operations = opers.ToArray();
            opernames = opernamesi.ToArray();
        }

        public Double Exec(String operName, Double? x, Double? y)
        {
            
            IOperation operation = operations
                .FirstOrDefault(o => o.Name == operName);         
            if (operation==null)
                return double.NaN;

            operation.Args = new Double[] { (Double)x, (Double)y };
            return (double)operation.Result;
        }

        #region old
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

#endregion old