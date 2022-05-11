using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N:");
            int N = Convert.ToInt32(Console.ReadLine());

            int k = 0;
            int Stp = 1;

            while (Stp * 3 < N) 
            {
                Stp *= 3; 
                k = k + 1;

            }
            Console.WriteLine($"Ответ:{ k }");
            Console.Read();
        }
    }
}
