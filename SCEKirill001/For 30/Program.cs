using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N:");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите A:");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите B:");
            int B = Convert.ToInt32(Console.ReadLine());

            float H = (B - A) / N;

            for (float i = A; i <= B; i+= H)

            {
                double Sin = 1 - Math.Sin(i);
                Console.WriteLine($"({i}:{Sin})"); 
            }
            Console.Read();
        }
    }
}
