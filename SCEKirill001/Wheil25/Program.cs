using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wheil25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите а:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите b:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите c:");
            int c = Convert.ToInt32(Console.ReadLine());

            int g = 0;
            int d = 0;
            int ca = 0;
            int cb = 0;
            int x = 0;
            while(a >= ca)
            {
                ca = ca + c;

                g = g + 1;

                
             }

            while (b >= cb)
            {
                cb = cb + c;

                d = d + 1;
            }
            for (int i = 0; i < d - 1; i++)   
            {
                x = x + g - 1;
            }

            Console.WriteLine($"Ответ: {x}");

            Console.Read();

        }
    }
}
