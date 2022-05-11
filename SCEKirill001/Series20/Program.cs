using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n:");
            int n = Convert.ToInt32(Console.ReadLine());

            int k = 0;

            Console.Write("Введите числа:");
            int c = Convert.ToInt32(Console.ReadLine());
    
            int i = 1;

            for (; i < n; i++)
            {
                Console.Write("Введите числа:");
                int N = Convert.ToInt32(Console.ReadLine());

                if (c > N)
                {
                    k += 1;
                    Console.WriteLine($"Ответ:{c}");
                }
                c = N;
            }

            
            Console.WriteLine($"Ответ:{k}");
            Console.Read();
        }
    }
}
