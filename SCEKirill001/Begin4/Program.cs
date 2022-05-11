using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите диаметр окружности: ");
            int Diameter = Convert.ToInt32(Console.ReadLine());

            float Circumference = 3.14f * Diameter ;

            Console.WriteLine("Вот ваш гребаный ответ: {0}", Circumference);

            Console.Read();
        }
    }
}
