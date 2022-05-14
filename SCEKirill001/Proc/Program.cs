using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proc
{
    class Program
    {
        static void Main(string[] args)
        {
            double b = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Введите А:");
                double aa = Convert.ToDouble(Console.ReadLine());
                b = Power3A(aa);
                Console.WriteLine($"Ответ:{b}");
            }
            Console.Read();
        }

        private static double Power3A(double ab)
        {
            return Math.Pow(ab, 3);
        }
    }
}
