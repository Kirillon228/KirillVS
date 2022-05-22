using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proc20
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
            Console.Write("Введите основание треугольника:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите высоту");
            double h = Convert.ToDouble(Console.ReadLine());

            double PerimeterTriangle = 0;

            PerimeterTriangle = TriangleP(a, h);

            PerimeterTriangle = Math.Sqrt(PerimeterTriangle);

            Console.WriteLine($"Ответ:{PerimeterTriangle*2+a}");
            }
            Console.Read();

        }
        private static double TriangleP(double a,double h)
        {
            double PerimeterTriangle = 0;

            return PerimeterTriangle = Math.Pow((a / 2), 2) + Math.Pow(h, 2);

        }
    }
}
