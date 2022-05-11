using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integro29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите в см А:");
            uint A = Convert.ToUInt32(Console.ReadLine());

            Console.Write("Введите см B:");
            uint B = Convert.ToUInt32(Console.ReadLine());

            Console.Write("Введите см C:");
            uint C = Convert.ToUInt32(Console.ReadLine());

            uint Sk = (A / C) * (B / C);
            uint Sv = (A * B) - Sk * (C * C);

            Console.WriteLine("Сколько квадратов: {0}", Sk);
            Console.WriteLine("Ответ в см^2: {0}", Sv);

            Console.Read();

            


        }
    }
}
