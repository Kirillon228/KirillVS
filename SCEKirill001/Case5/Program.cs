using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N от 1 до 4:");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите A:");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите B не равно 0:");
            int B = Convert.ToInt32(Console.ReadLine());

            switch (N)
            {
                case 1:
                    Console.WriteLine("Ответ: {0}", A + B);

                    break;
                case 2:
                    Console.WriteLine("Ответ: {0}", A - B);

                    break;

                case 3:
                    Console.WriteLine("Ответ: {0}", A * B);

                    break;

                case 4:
                    float C = (float)A / B;
                    Console.WriteLine("Ответ: {0}",C);

                    break;

                default:
                    Console.WriteLine("Идите нахуй");
                    break;


            }
            Console.Read();
        }
    }
}
