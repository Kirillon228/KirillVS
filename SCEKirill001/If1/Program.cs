using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:");
            int Number = Convert.ToInt32(Console.ReadLine());

            if (Number >= 0)
            {
                int Nuber1 = Number + 1;

                Console.WriteLine("Ответ: {0}",Nuber1);
            }
            else
            {
                Console.WriteLine("Ответ: {0}",Number);
            }
            Console.Read();
        }
    }
}
