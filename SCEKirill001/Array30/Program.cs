using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < n; i++) 
            {
                Console.Write("Введите число:");
                array [i]= Convert.ToInt32(Console.ReadLine());
            }
            bool a = false;
            int b = 0;
            for (int j = 0; j < n-1; j++)
            {
                if (array [j] > array [j+1])
                {
                    b++;
                    a = true;
                    Console.WriteLine($"Ответ:{j}");
                }                
            }
            if (a == false)
            {
                Console.WriteLine("Ответов нет");
            }
            Console.WriteLine($"Количество:{b}");

            Console.Read();
        }
    }
}
