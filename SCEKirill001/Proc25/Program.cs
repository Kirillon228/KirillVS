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
               
                Console.WriteLine(IsSquare(number));
            }
            Console.Read();
        }
        private static bool IsSquare(int number)
        {
            return (Math.Sqrt(number)) % 1 == 0;           
        }
    }
}
