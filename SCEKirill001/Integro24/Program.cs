using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integro24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите любое число от 1 до 365:");
            uint Day = Convert.ToUInt32(Console.ReadLine());

            uint WeekDay = Day % 7;

            Console.WriteLine("Ответ: {0}", WeekDay);

            Console.Read();




        }
    }
}
