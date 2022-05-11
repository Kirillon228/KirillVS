using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите Х:");
            int XStart = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите Y:");
            int YStart = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите Х2:");
            int XEnd = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите Y2:");
            int YEnd = Convert.ToInt32(Console.ReadLine());

            int Dx = Math.Abs(XEnd - XStart);
            int Dy = Math.Abs(YEnd - YStart);

            bool result = (Dx == 1 && Dy == 2) ^ (Dy == 1 && Dx == 2);
            Console.WriteLine(result);

            Console.Read();
        }
    }
}
