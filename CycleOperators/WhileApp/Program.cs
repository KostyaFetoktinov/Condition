using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите бюджет проекта");
            int budget = int.Parse(Console.ReadLine());
            int count = 0;

            while (budget > 0)
            {
                Console.WriteLine("Введите зарплату: ");
                int salary = int.Parse(Console.ReadLine());

                budget -= salary;
                count++;
            }

            Console.WriteLine("Кол-во нанятых сотрудников = " + count);
            Console.ReadLine();
        }
    }
}
