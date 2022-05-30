using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите числа:");
                array[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int j = n - 1; j >= 0; j--) 
            {
                Console.WriteLine($"Ответ:{array[j]}");
            }
            Console.Read();

        }
    }
}
