using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите Х :");
            int X = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите Y :");
            int Y = Convert.ToInt32(Console.ReadLine());

            bool GPS = X <= 0;
            bool GPV = Y >= 0;

            Console.WriteLine(GPS && GPV);

            Console.Read();

        }
    }
}
