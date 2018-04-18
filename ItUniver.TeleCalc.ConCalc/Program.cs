using ItUniver.TeleCalc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ItUniver.TeleCalc.ConCalc
{
    class Program
    {
        static void Main(string[] args)
        {
             try
            {
                
                var calc = new Calc();             
                    if (args.Length >= 3) 
                    {
                        string operName = args[0];
                        double x = Convert.ToDouble(args[1]);
                        double y = Convert.ToDouble(args[2]);

                        double? result = calc.Exec(operName, x, y);

                        Console.WriteLine("{0} {1} {2}={3}",x,operName,y,result);
                     }
                    else
                    {
                        Console.WriteLine("Введите команду: ");
                        string operName = Console.ReadLine();
                        Console.WriteLine("Введите переменую1: ");
                        double x=Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите переменую2: ");
                        double y = Convert.ToDouble(Console.ReadLine());
                        double? result = calc.Exec(operName, x, y);

                        Console.WriteLine("{0} {1} {2} = {3}", x, operName, y, result);
                    }
                }
            
            catch (Exception ex)
            {
                Console.WriteLine("Тут ошибочка \n" + ex.Message);
            }
            finally
            {
                Console.WriteLine("Для продолжения нажмите любую клавишу...");
                Console.ReadKey();
            }
        }
    }
}
