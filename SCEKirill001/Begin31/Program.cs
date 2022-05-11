using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите температуру в градусах по Фаренгейту: ");
            float Tf = Convert.ToSingle(Console.ReadLine());

            float Tc = (float)((Tf - 32) * 5 / 9);

            Console.WriteLine("Температура в градусах по цельсию:{0}", Tc);

            Console.Read();
        }
    }
}
