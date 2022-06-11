using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array116
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = InputArray(n);
            (int[] B, int[] C) = SeriesIntegersArray(array);

            Console.WriteLine("Измененный массив:");
            OutPutArray(B, C);

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

        private static (int[], int[]) SeriesIntegersArray(int[] array)
        {
            List<int> B = new List<int>();
            List<int> C = new List<int>();

            for (int i = 0, j = 1, count = 1, k = 0; j < array.Length; i++, j++) 
            {
                if (array[i] == array[j])
                {
                    k = 1;
                    count++;
                    if(j == array.Length-1)
                    {
                        C.Add(array[i]);
                        B.Add(count);
                    }                    
                }     
                else if (k ==1)
                {
                    C.Add(array[i]);
                    B.Add(count);
                    k = 0;
                    count = 1;
                }
                else
                {
                    B.Add(1);
                    C.Add(array[i]);                    
                }             
                
            }
            return (B.ToArray(), C.ToArray());
        }

        private static void OutPutArray(int[] B, int[] C)
        {
            for (int i = 0; i < B.Length; i++)

            {
                Console.WriteLine($"element [{i}] => {C[i]}, count => {B[i]}");
            }
        }
    }
}
