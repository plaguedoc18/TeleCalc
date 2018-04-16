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
            try
            {
                var calc = new Calc();
                Double res;
                if (args.Length == 0) Console.WriteLine("Нет аргументов");
                else if (args.Length < 2) Console.WriteLine("Не хватает аргументов");
                else
                {
                    if ((args.Length == 2) && (args[1] == "cube"))
                    {
                        res = calc.Cube(Convert.ToDouble(args[1]));
                        Console.WriteLine("=" + res);
                    }
                    if (args.Length < 3) Console.WriteLine("Не хватает аргументов");
                    else
                        switch (args[0])
                        {
                            case "sum":
                                res = calc.Sum(Convert.ToDouble(args[1]), Convert.ToDouble(args[2]));
                                Console.WriteLine("=" + res);
                                break;
                            case "sub":
                                res = calc.Sub(Convert.ToDouble(args[1]), Convert.ToDouble(args[2]));
                                Console.WriteLine("=" + res);
                                break;
                            case "mult":
                                res = calc.Mult(Convert.ToDouble(args[1]), Convert.ToDouble(args[2]));
                                Console.WriteLine("=" + res);
                                break;
                            case "div":
                                res = calc.Div(Convert.ToDouble(args[1]), Convert.ToDouble(args[2]));
                                Console.WriteLine("=" + res);
                                break;
                            default:
                                Console.WriteLine("Неверная команда!");
                                break;
                        }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Тут ошибочка \n" + ex.Message);
            }
            finally
            {
                Console.WriteLine("Press any key for continue...");
                Console.ReadKey();
            }
        }
    }
}
