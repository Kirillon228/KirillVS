using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите А:");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите B:");
            int B = Convert.ToInt32(Console.ReadLine());

            if (A != B)
            {
                int Sum = A + B;
                A = Sum;
                B = Sum;
                Console.WriteLine("A= {0}", A);
                Console.WriteLine("B= {0}", B);
            }
            else
            {
                A = 0;
                B = 0;

                Console.WriteLine("A= {0}", A);
                Console.WriteLine("B= {0}", B);
            }
            Console.Read();

        }
    }
}
