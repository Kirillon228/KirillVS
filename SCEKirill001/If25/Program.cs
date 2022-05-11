using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If25
{
    class Program
    {
        static int Y(int x)
        {
            if (x < -2 || x > 2)
            {
                return 2 * x;
            }
            else
            {
                return -3 * x;

            }
        }
        static void Main(string[] args)

        {
            Console.Write("Введите X:");
            int X = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ответ: {0}", Y(X));
            Console.Read();
        }
    }
}
