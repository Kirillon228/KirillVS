using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proc25
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Введите число:");
                int number = Convert.ToInt32(Console.ReadLine());
                double c = 0;
                bool answer = false;

                c = IsSquare(number);
                if (c == 0)
                {
                    answer = true;
                }
                Console.WriteLine(answer);
            }
            Console.Read();
        }
        private static double IsSquare(int number)
        {
            double c = 0;
            return c = (Math.Sqrt(number)) % 1;
        }
    }
}
