using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите k:");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите n:");
            int n = Convert.ToInt32(Console.ReadLine());

            int Sum = 0;

            for (int i = 0; i < k; i++)
            {
                for (int ui = 0; ui < n; ui++)
                {
                    Console.Write("Введите числа:");
                    int number = Convert.ToInt32(Console.ReadLine());

                    Sum += number;
                }
                Console.WriteLine($"Ответ:{Sum}");

                Sum = 0;
            }
            
            Console.Read();


        }
    }
}
