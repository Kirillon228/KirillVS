using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите А:");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите B:");
            int B = Convert.ToInt32(Console.ReadLine());

            bool ComparisonA = A > 2;
            bool ComparisonB = B <= 3;

            Console.WriteLine(ComparisonA);
            Console.WriteLine(ComparisonB);

            Console.Read();

        }
    }
}
