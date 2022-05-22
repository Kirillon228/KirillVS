using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proc30
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Введите число:");
                int k = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите число:");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(DigitN(k, n));
            }
            Console.Read();

        }
        private static int DigitN(int k, int n)
        {
            int tem = k;
            int i = 0;
            for (; ; i++)
            {
                k /= 10;
                if (k < 1)
                {
                    break;
                }
            }
            if (i < n)
            {
                return i = 1;
            }
            else
            {
                for (int j = 0; j < n; j++) 
                {
                    tem = tem / 10;
                    
                }
                return tem % 10;
            }
           
        }    
    }
}
