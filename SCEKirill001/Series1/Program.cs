using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series1
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] array = new int[10];


            for (int i = 0; i < 10; i++) 
            {
                Console.Write("Введите число:");
                int a = Convert.ToInt32(Console.ReadLine());
                array[i] = a;
            }

            int Sum = 0;

           
            for (int i = 0; i < array.Length; i++) 
            {
                Sum += array[i];
                
            }
            Console.WriteLine($"Ответ:{Sum}");
            Console.Read();
        }
    }
}
