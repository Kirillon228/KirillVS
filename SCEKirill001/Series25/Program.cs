using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n:");
            int n = Convert.ToInt32(Console.ReadLine());

            int c = 0;
            int f = 0;
            bool FoundZero = false;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите числа:");
                int N = Convert.ToInt32(Console.ReadLine());

                if (N == 0)
                {

                    FoundZero = true;

                    f = c;
                    c = 0;
                }
                else if (FoundZero)
                {
                    c += N;
                }
            }    

            Console.WriteLine($"Ответ:{f}");
            Console.Read();
        }
    }
}
