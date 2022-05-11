using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите k:");
            int k = Convert.ToInt32(Console.ReadLine());

            
            int n = -1;

            for (int i = 0; ; i++)
            {
                Console.Write("Введите числа:");
                int c = Convert.ToInt32(Console.ReadLine());

                
                
                if (c == 0)
                {
                    break;
                }

                if (c > k && n == -1)
                {
                    n = i;
                    
                    
                }
            }

            Console.WriteLine($"Ответ:{n}");

            Console.Read();

        }
    }
}
