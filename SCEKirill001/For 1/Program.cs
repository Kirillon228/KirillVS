using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите К:");
            int K = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите N:");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <=N; i++)
            {
                Console.WriteLine("Ответ: {0} ", K);
            }
            Console.Read();
        }
    }
}
