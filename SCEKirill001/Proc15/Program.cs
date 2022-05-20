using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proc15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число А:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите число B:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите число C:");
            double c = Convert.ToDouble(Console.ReadLine());

            ShiftLeft(ref a, ref b, ref c);
            Console.WriteLine($"A= {a}\n" +
                              $"B= {b}\n" +
                              $"C= {c}"
            );

            ShiftLeft(ref a, ref b, ref c); 
            Console.WriteLine($"A= {a}\n" +
                              $"B= {b}\n" +
                              $"C= {c}"
            );

            Console.Read();
        }
        private static void ShiftLeft(ref double d,ref double e,ref double f)
        {
            double temp = d;
            d = e;
            e = f;
            f = temp;
        }
    }
}
