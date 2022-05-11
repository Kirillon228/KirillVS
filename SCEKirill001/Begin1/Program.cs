using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ведите сторну квадрата(целое число): ");
            float SideSquare = Convert.ToSingle(Console.ReadLine());

            float PerimeterSquare = 4 * SideSquare;

            Console.WriteLine("Периметр равен: {0}", PerimeterSquare);

            Console.Read();
        }
    }
}
