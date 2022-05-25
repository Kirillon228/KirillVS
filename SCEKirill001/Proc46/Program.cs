using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proc46
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:");
            int a = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите число:");
                int b = Convert.ToInt32(Console.ReadLine());
               
                    Console.WriteLine($"Нод:{Nod2(a, b)}");
                Console.Read();
            }
             
        }
        private static int Nod2(int a,int b)
        {
           for(int i = 0; ; i++)
            {
                if (a == 0 || b == 0) 
                {
                    return a + b;                   
                }
                
                if (a > b) 
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }
        }
    }
}
