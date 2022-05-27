using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMin1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество чисел:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число:");
            int a = Convert.ToInt32(Console.ReadLine());

            int answer = a;
            int answer2 = a;

            for (int i = 1; i < n; i++) 
            {
                Console.Write("Введите число:");
                int b = Convert.ToInt32(Console.ReadLine());
                if (b > answer) 
                {
                    answer = b;

                }
                if (b < answer2) 
                {
                    answer2 = a;
                }              
            }
            Console.WriteLine($"Max:{answer}");
            Console.WriteLine($"Min:{answer2}");
            Console.Read();
        }
    }
}
