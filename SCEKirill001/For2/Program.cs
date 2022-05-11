using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For2
{
    class Program
    {                                                                 
        static void Main(string[] args)
        {
            Console.Write("Введите А:");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите B:");
            int B = Convert.ToInt32(Console.ReadLine());

            int C = B - A;
            for (int i = A; i <= B; i++)
            {
                Console.WriteLine("Ответ: {0}", i);
            }
            Console.WriteLine("Ответ: {0}", C + 1);
            Console.Read();
        }
    }
}
