using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число от 100 до 999 и от -999 до -100:");
            int Number = Convert.ToInt32(Console.ReadLine());

            int A = Number % 10;
            int B = Number % 100 / 10;
            int C = Number / 100;

            bool G = A != B;
            bool F = A != C;
            bool D = B != C;

                   
            Console.WriteLine(G&&F&&D);

            Console.Read();

        }
    }
}
