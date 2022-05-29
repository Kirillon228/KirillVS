using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax30
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
            int c = 0;           
            int answer2 = int.MaxValue;
           
            for (int i = 1; i < n; i++)
            {
                Console.Write("Введите число:");
                int b = Convert.ToInt32(Console.ReadLine());

                if (b > answer)
                {
                    answer = b;
                    answer2 = int.MaxValue;
                    c = 0;
                }                
                if (b == answer) 
                {
                    c++;
                }
                else
                {
                    if (c < answer2)
                    {
                        answer2 = c;
                    }
                    c = 0;
                }               
            }            
            Console.WriteLine($"Ответ:{answer2}");
            Console.Read();
        }
    }
}
