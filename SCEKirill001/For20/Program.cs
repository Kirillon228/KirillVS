using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N:");
            int N = Convert.ToInt32(Console.ReadLine());

            float Fac = 1;

            for (int i = 1; i <= N; i ++ )
            {
                Fac *= i;
            }
            Console.WriteLine($"Ответ: {Fac}");

            Console.Read();
        }
    }
}
