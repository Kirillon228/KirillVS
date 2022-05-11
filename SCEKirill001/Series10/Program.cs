using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0;i < n;i++)
            {
                Console.Write("Введите числа:");
                array[i] = Convert.ToInt32(Console.ReadLine());

            }

            bool k = false;

            for (int i = 0; i < n; i++) 
            {

                if(array[i] > 0)
                {
                    k = true;

                    break;
                }

            }

            Console.WriteLine(k);

            Console.Read();

        }
    }
}
