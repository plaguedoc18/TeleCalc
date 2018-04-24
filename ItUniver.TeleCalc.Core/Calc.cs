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
        private string[] opernames { get; set; }
        public IEnumerable<string> GetOperNames()
        {
            return operations.Select(o => o.Name);
        }

        private double Result { get; set; }
        public double GetResult { get { return Result; } }

        public Calc()
        {
            var opers = new List<IOperation>();
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
                }
            }

            operations = opers.ToArray();
           
        }
        //[Obsolete("Используйте метод Exec(operName, args)")]
        public double Exec(String operName, double x, double y)
        {
            return Exec(operName,new double[] {x,y});
          
        }
        public double Exec(String operName, IEnumerable<double> args)
        {
            
            IOperation operation = operations
                .FirstOrDefault(o => o.Name == operName);
            if (operation == null)
            {
                return double.NaN;
            }
            operation.Args = args.ToArray();
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