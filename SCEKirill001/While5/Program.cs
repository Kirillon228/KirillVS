using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N:");
            int N = Convert.ToInt32(Console.ReadLine());

            int k = 0;

            while (N > 1)
            {

                N = N / 2;
                k = k + 1;
                
            }
            Console.WriteLine($"Ответ:{k}");

            Console.Read();
        }
    }
}
