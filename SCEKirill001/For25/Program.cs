using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите Х:");
            float X = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите N:");
            int N = Convert.ToInt32(Console.ReadLine());

            float XHT = 0;

            for (float i = 1; i <= N; i++)
            {
                int coef = i % 2 == 0 ? -1 : 1;
                XHT += (float)Math.Pow(X, i) / i * coef;
            }
           
                      Console.WriteLine($"Ответ: {XHT} ");

            Console.Read();
        }
    }
}
