using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите А:");
            float A = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите N:");
            int N = Convert.ToInt32(Console.ReadLine());

            float step = 1;

            for (float i = 1; i <= N; ++i)
            {
                step *= A;

            }
            Console.WriteLine($"Ответ: {step}");

            Console.Read();
        }
    }
}
