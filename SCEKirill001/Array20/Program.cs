using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количетво чисел:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите начало:");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите конец:");
            int l = Convert.ToInt32(Console.ReadLine());

            int g = 0;

            int[] array = new int[n];

            for(int i = 0; i < n; i++)
            {
                Console.Write("Введите число:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int j = k-1; j <= l-1; j++)
            {
                g += array[j];
            }
            Console.WriteLine($"Ответ:{g}");
            Console.Read();
        }
    }
}
