using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива (Четное число):");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = InputArray(n);
            SwithHalfElementsArray(array);
            Console.WriteLine("Измененный массив:");
            OutPutArray(array);

            Console.Read();
        }
        private static int[] InputArray(int n)
        {
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите element [{i}] => ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            return array;
        }
        private static int[] SwithHalfElementsArray(int[] array)
        {
            for(int i = 0; i < array.Length / 2; i++)
            {
                int TempA = array[i];
                int TempB = array[array.Length / 2 + i];

                array[i] = TempB;
                array[array.Length / 2 + i] = TempA;
            }
            return array;
        }
        private static void OutPutArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"element [{i}] => {array[i]}");
            }
        }
    }
}
