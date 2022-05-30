using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество чисел:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите числа:");
                array[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int j = 0; j < n; j += 2)
            {
                Console.WriteLine($"Не четные:{array[j]}");
            }
            int[] array2 = new int[n/2];
            for (int v = 1, i = 0; v < n; v += 2, i++)
            {
                array2[i] = array[v];
            }
            for (int c = n/2 - 1; c >= 0; c--)
            {
                Console.WriteLine($"Ответ:{array2[c]}");
            }
            Console.Read();
        }
    }
}
