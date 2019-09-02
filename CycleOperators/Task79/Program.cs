using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task79
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.Write(i + " ");
            //}

            //int i = 1;
            //while (i <= 20)
            //{
            //    Console.Write(i + " ");
            //    i++;
            //}

            int i = 1;
            do
            {
                Console.Write(i + " ");
                i++;
            }
            while (i <= 20);

            Console.ReadLine();
        }
    }
}
