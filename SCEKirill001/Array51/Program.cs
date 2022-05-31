using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array51
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Зaполните массив А");
            var arrayA = InputArray(n);

            Console.WriteLine("Зaполните массив B");
            int[] arrayB = InputArray(n);

            Console.WriteLine("Произведем обмен");
            
            SwithElementsArray(arrayA, arrayB);

            Console.WriteLine("Новый массив А");
            OutPutArray(arrayA);

            Console.WriteLine("Новый массив B");
            OutPutArray(arrayB);
            Console.Read();
        }
        private static int[] InputArray(int n)
        {
            int[] array = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.Write($"Введите element [{i}] => ");
                array[i] = Convert.ToInt32(Console.ReadLine());                
            }

            return array;
        }
        private static void SwithElementsArray(int [] arrayA, int [] arrayB)
        {
            for(int i = 0; i < arrayA.Length; i++)
            {
                int temp = arrayA[i];
                arrayA[i] = arrayB[i];
                arrayB[i] = temp;
            }
        }
        private static void OutPutArray(int[] array)
        {
            for(int i = 0; i< array.Length; i++)
            {
                Console.WriteLine($"element [{i}] => {array[i]}");
            }
        }
    }
}
