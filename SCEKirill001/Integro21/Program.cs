using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integro21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение в секундах:");
            uint Seconds = Convert.ToUInt32(Console.ReadLine());

            uint Ostatok = Seconds % 60;

            Console.WriteLine("Ответ: {0}", Ostatok);

            Console.Read();

        }
    }
}
