using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n:");
            int n = Convert.ToInt32(Console.ReadLine());

            double[] array = new double[n];

            for (int i = 0;i < n; i++)
            {
                Console.Write("Введите числа:");
                 array[i] = Convert.ToDouble(Console.ReadLine());

            }

            
            double Sum = 0;
            double Ym = 1;

            for (int i = 0;i < array.Length;i++)
            {
                Sum += array[i];
                Ym = Ym * array[i];


            }
            Console.WriteLine($"Ответ:{Sum}");
            Console.WriteLine($"Ответ:{Ym}");

            Console.Read();
        }
    }
}
