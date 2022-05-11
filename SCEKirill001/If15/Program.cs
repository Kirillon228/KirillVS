using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите A:");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите B:");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите C:");
            int C = Convert.ToInt32(Console.ReadLine());

            int SumA = A + B;
            int SumAA = A + C;
            int SumAAA = B + C;

            if (A >= C && B >= C) 
            {
                Console.WriteLine("Ответ: {0}", SumA);

            }
            else if (A >= B && C >= B) 
            {
                Console.WriteLine("Ответ: {0}", SumAA);
            }
            else if (A <= B && A <= C) 
            {
                Console.WriteLine("Ответ: {0}", SumAAA);
            }
            else if (A == C && B == A && C == B)
            {
                Console.WriteLine("Ответ: {0}", SumAAA);
            }


            Console.Read();
        }
    }
}
