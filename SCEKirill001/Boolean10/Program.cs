using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите А:");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите B:");
            int B = Convert.ToInt32(Console.ReadLine());

            bool EvenA = A % 2 == 0;
            bool EvenB = B % 2 == 0;

            Console.WriteLine(EvenA ^ EvenB);

            Console.Read();
        }
    }
}
