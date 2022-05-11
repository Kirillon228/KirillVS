using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите год:");
            int Year = Convert.ToInt32(Console.ReadLine());

            if (Year % 4 == 0)
            {
                if (Year % 100 == 0)
                {
                    if (Year % 400 == 0)
                    {
                        Console.WriteLine("Год високосный");
                    }
                    else
                    {
                        Console.WriteLine("Год не високосный");
                    }
                }
                else
                {
                    Console.WriteLine("Год високосный");
                }
            }
            else
            {
                Console.WriteLine("Год не високосный");

            }



            Console.Read();


        }
    }
}
