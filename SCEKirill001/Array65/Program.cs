using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array65
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число:");
            int k = Convert.ToInt32(Console.ReadLine());

            int[] array = InputArray(n);
            SumConstantVelueToElementsArray(array, k);        
            Console.WriteLine($"Преобразованный массив:");
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
        private static void SumConstantVelueToElementsArray(int[] array,int k)
        {
            int constantValue = array[k];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] += constantValue;
            }            
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
