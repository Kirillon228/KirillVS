using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите аргумент: ");
            float Argument = Convert.ToSingle(Console.ReadLine());

            float FunctionValue = (float)(Math.Pow(Argument, 6)*3 - Math.Pow(Argument, 2)*6 - 7);

            Console.WriteLine("Значение функции:{0} ", FunctionValue);

            Console.Read();
        }
    }
}
