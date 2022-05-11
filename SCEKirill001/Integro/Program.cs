using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значени от 100 до 999,от -999 до -100:");
            int ThreeDigitNumber = Math.Abs(Convert.ToInt32(Console.ReadLine()));

            int units = ThreeDigitNumber % 10;

            int dozens = ThreeDigitNumber % 100 / 10;
                     
            Console.WriteLine("Десятки:{0}", dozens);
            Console.WriteLine("Единицы:{0}", units);

            Console.Read();

        }
    }
}
