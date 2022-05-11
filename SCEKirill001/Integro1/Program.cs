using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integro1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение в сантиметрах:");
            int Centimeter = Convert.ToInt32(Console.ReadLine());

            int Meter = Centimeter / 100;

            Console.WriteLine("Ответ:{0}", Meter);

            Console.Read();

               
        }
    }
}
