using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сторону треугольника а:");
            uint STRA = Convert.ToUInt32(Console.ReadLine());

            Console.Write("Введите сторону треугольника b:");
            uint STRB = Convert.ToUInt32(Console.ReadLine());

            Console.Write("Введите сторону треугольника c:");
            uint STRC = Convert.ToUInt32(Console.ReadLine());


            bool A = STRA == STRB && STRA == STRC;
            
                    Console.WriteLine(A);

            Console.Read();
        }
    }
}
