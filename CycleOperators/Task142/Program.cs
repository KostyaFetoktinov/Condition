using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task142
{
    class Program
    {
        static void Main(string[] args)
        {
            //создание экземпляра класса
            Random rand = new Random();
            int oper;

            do
            {
                int computer = rand.Next(1, 100);
                Console.WriteLine(computer);

                for (int i = 0; i < 3; i++)
                {
                    Console.Write("Введите число: ");
                    int user = int.Parse(Console.ReadLine());

                    if (user > computer)
                        Console.WriteLine("Загаданное число меньше");
                    else if (user < computer)
                        Console.WriteLine("Загаданное число больше");
                    else
                    {
                        Console.WriteLine("Вы выйграли!");
                        break;
                    }
                }

                Console.WriteLine("Введите 1 для выхода или 2 для повторной игры");
                oper = int.Parse(Console.ReadLine());
            }
            while (oper != 1);
        }
    }
}
