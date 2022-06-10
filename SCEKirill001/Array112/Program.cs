using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array112
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = InputArray(n);
            array = arrayStoring(array);

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
        private static int[] arrayStoring(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int b = 0, j = 1; j < array.Length; b++, j++)
                {
                    if (array[b] > array[j])
                    {                       
                        int temp = array[b];
                        array[b] = array[j];
                        array[j] = temp;
                    }
                }
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
