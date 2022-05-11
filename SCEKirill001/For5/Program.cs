using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите цену 1 кг конфет:");
            float A = Convert.ToSingle(Console.ReadLine());

            for (float i = 0.1f; i <= 1; i += (float)0.1)
            {
                Console.WriteLine("Ответ: {0}", A *i);
            }
            Console.Read();
        }
    }
}
