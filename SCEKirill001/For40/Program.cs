using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите А:");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите B:");
            int B = Convert.ToInt32(Console.ReadLine());

            int C = B - A;

            for (int i = 0; i <= C; i++) 
            {
                Console.Write("Ответ:");
                for (int j = 0 ; j <= i; j++)
                {
                    Console.Write($"{A + i}");
                    
                }
                Console.WriteLine();
            }
           
            Console.Read();
        }
    }
}
