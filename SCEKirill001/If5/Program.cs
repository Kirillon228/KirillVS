using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число а:");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число b:");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число c:");
            int C = Convert.ToInt32(Console.ReadLine());

           
            int Count = 0;
            

            if (A > 0)
            {
                Count = Count + 1; 
            }
            if (B > 0)
            {
                Count += 1;
            }
            if (C > 0)
            {
                Count++;
            }
            Console.WriteLine("Ответ: {0}", Count);

            Console.Read();
        }
    }
}
