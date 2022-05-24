using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proc38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:");
            double a = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите степень числа:");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Ответ:{Power2(a,n)}");
            }
            Console.Read();

        }
        private static double Power2(double a,int n)
        {
            a = Math.Pow(a, Math.Abs(n));
            if (n < 0)
            {
                a = 1 / a;
            }       
            return a;
        }
    }
}
