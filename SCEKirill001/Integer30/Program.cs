using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер года:");
            double year = Convert.ToDouble(Console.ReadLine());

            double century = Math.Ceiling(year / 100.0);

            Console.Write("Ответ: {0}", century);

            Console.Read();
        }
    }
}
