using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Кол-во пунктов = ");
            int count = int.Parse(Console.ReadLine());

            int total = 0;

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Введите расстояние: ");
                int r = int.Parse(Console.ReadLine());
                if (r < 0)
                    continue;

                total += r;
            }

            Console.WriteLine("Суммарное расстояние = " + total);
            Console.ReadLine();
        }
    }
}
