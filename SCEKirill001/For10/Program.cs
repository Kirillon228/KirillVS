using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N:");
            float N = Convert.ToSingle(Console.ReadLine());
            float sum = 0;

            for (float i = 1; i <= N; i += 1)
            {
                sum += 1 / i;
            }
            
            Console.WriteLine($"Ответ:{sum}");

            Console.Read();
        }
    }
}
