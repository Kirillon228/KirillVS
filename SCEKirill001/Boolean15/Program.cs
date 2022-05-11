using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите А:");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите B:");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите C:");
            int C = Convert.ToInt32(Console.ReadLine());

            bool Apos = A > 0;
            bool Bpos = B > 0;
            bool Cpos = C > 0;

            Console.WriteLine(Apos ^ Bpos && Cpos || Apos ^ Cpos && Bpos || Bpos ^ Cpos && Apos );

            Console.Read();





            

        }
    }
}
