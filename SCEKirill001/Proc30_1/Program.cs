using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proc30
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Введите число:");
                int k = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите число:");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(DigitN(k, n));
            }
            Console.Read();

        }
        private static int DigitN(int k, int n)
        {

            for (int i = 0; k > 0; i++)
            {
                if (i == n)
                {
                    return k % 10;

                }
                k /= 10;
            }
            return -1;
        }
    }
}
