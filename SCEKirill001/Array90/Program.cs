using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array90
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число:");
            int k = Convert.ToInt32(Console.ReadLine());
                       
            if (n <= k)
            {
                int[] array = InputArray(n);
                int[] arrayWhithoutElementK = DeleteElementArray(array, k);

                Console.WriteLine("Измененный массив:");
                OutPutArray(arrayWhithoutElementK);
            }
            else
            {
                Console.WriteLine("Так делать нельзя");
            }
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
        private static int[] DeleteElementArray(int[] array, int k)
        {
            int[] ArrayWhithoutElementK = new int[array.Length - 1];

            for (int i = 0,j=0; i < array.Length; i++)
            {
                if (i != k)
                {                    
                    ArrayWhithoutElementK[j] = array[i];
                    j++;
                }
            }

            return ArrayWhithoutElementK;
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
