using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите занчение переменной А (не равно 0):");
            float PermennauA = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите занчение переменной B:");
            float PermennauB = Convert.ToSingle(Console.ReadLine());

            float X = (float)(-PermennauB / PermennauA);

            Console.WriteLine("Ответ: {0}", X);

            Console.Read();



        }
    }
}
