using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите А:");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите B:");
            int B = Convert.ToInt32(Console.ReadLine());

            int C = 0;

            while (C <= A - B)  
            {
                C = C + B;
                
            }


            Console.WriteLine($"Ответ:{A - C}");

            Console.Read();
        }
    }
}
