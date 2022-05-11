using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите катет a: ");
            float LegA = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите катет b: ");
            float LegB = Convert.ToSingle(Console.ReadLine());

            float hypotenuse = (float)Math.Sqrt(Math.Pow(LegA, 2) + Math.Pow(LegB, 2));
            float perimeter = (LegA + LegB + hypotenuse);

            Console.WriteLine("Гипотенуза:{0}", hypotenuse);
            Console.WriteLine("Периметр:{0}", perimeter);

            Console.Read();
                        
        }
    }
}
