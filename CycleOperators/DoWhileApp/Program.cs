using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int oper;

            do
            {
                Console.WriteLine("1.Сложение");
                Console.WriteLine("2.Вычитание");
                Console.WriteLine("3.Умножение");
                Console.WriteLine("0.Выход");

                oper = int.Parse(Console.ReadLine());
                if (oper != 0)
                {
                    Console.WriteLine("Введите первое число");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число");
                    int num2 = int.Parse(Console.ReadLine());

                    int result = 0;

                    switch (oper)
                    {
                        case 1:
                            result = num1 + num2;
                            break;
                        case 2:
                            result = num1 - num2;
                            break;
                        case 3:
                            result = num1 * num2;
                            break;
                        default:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                            
                    }

                    Console.WriteLine($"Результат = {result}");
                }

            } while (oper != 0);
        }
    }
}
