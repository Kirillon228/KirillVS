using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите k:");
            int k = Convert.ToInt32(Console.ReadLine());

            int Sum = 0;
            int Suma = 0;

            for (int i = 0; i < k; i++) 
            {
                for (int ui = 0;; ui++) 
                {
                    Console.Write("Введите числа:");
                    int c = Convert.ToInt32(Console.ReadLine());

                    Sum += 1;
                    Suma += 1;

                    if (c == 0) 
                    {
                        Console.WriteLine($"Ответ:{Sum}");
                        break;
                    }


                }
           
            Sum = 0;
            }
            Console.WriteLine($"Ответ:{Suma}");

            Console.Read();
        }
    }
}
