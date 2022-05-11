using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите а: ");
            float a = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите b: ");
            float b = Convert.ToSingle(Console.ReadLine());

            float GeometricMean = (float)Math.Sqrt(a * b);

            Console.WriteLine("Ответ:{0}", GeometricMean);

            Console.Read();
        }
    }
}
