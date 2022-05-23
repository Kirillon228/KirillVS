using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proc35
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Введите число:");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(Fac2(n));
            }
            Console.Read();

        }
        private static int Fac2(int n)
        {
            int answer = 1;

            for (int i = n % 2 == 0 ? 2 : 1; i <= n; i += 2)
            {
                answer = answer * i;
            }
            return answer;          
        }


    }
}
