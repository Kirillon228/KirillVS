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
            int answer4 = 1;
            int answer2 = 2;
            int answer3 = 2;
            
            for (int i = 2; i < n; i += 2)  
            {
                if (n % 2 == 0)
                {
                    answer2 = answer2 * (answer3 += 2);
                    
                }
                else
                {
                    answer = answer * (answer4 += 2);

                }
            }
            if (n % 2 == 0)
            {
                return answer2;
            }
            else
            {
                return answer;
            }
           
        }


    }
}
