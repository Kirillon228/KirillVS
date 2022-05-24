using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proc37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите степень числа:");
            double p = Convert.ToDouble(Console.ReadLine());

            double answer = 0;

            for(int i = 0; i < 3; i++)
            {
                answer = 0;

                Console.Write("Введите число:");
                double a = Convert.ToDouble(Console.ReadLine());

                if(a < 1)
                {
                    Console.WriteLine($"ответ:{answer}");
                }
                else
                {
                    Console.WriteLine($"ответ:{Power1(a,p)}");
                }
            }
        }
        private static double Power1(double a, double p)
        {
            
            return Math.Exp(p * Math.Log(a));
        }
    }
}
