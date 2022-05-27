using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proc56
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 1 точку:");
            double ax = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите 1 точку:");
            double ay = Convert.ToDouble(Console.ReadLine());

            for (int i= 0;i < 3; i++)
            {
                Console.Write("Введите 2 точку:");
                double bx = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите 2 точку:");
                double by = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Ответ:{Leng(ax, ay, bx, by)}");
                
            }
            Console.Read();
        }
        private static double Leng(double ax, double ay, double bx, double by) 
        {
            double answer = Math.Sqrt(Math.Pow((ax - bx), 2) + Math.Pow((ay - by), 2));
            return Math.Abs(answer);
        }

    }
}
