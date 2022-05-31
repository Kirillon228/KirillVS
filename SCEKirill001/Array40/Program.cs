using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число:");
            int r = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];
            InputArray(array);
            int index = Nearest(array, r);
            Console.WriteLine($"Индекс массива:{index}, значение = {array[index]}");
            Console.Read();
        }
        private static void InputArray(int[] array)
        {          

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Введите число:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        private static int Nearest( int [] array ,int r)
        {
           
            int j = 0;
            for (int g = 0; j < array.Length; j++)
            {
                if (g == Math.Abs(array[j] - r))
                {
                    break;
                }

                if (j == array.Length - 1)
                {
                    j = 0;
                    g++;
                }                
            }
            return j;

        }
    }
}
