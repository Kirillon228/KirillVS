using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proc53
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите год:");
            int year = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите месяц:");
                int month = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(IsLeapYear(year, month));
                
            }
            Console.Read();
        }
        private static int IsLeapYear(int year, int month)
        {          

            if (year % 4 == 0)
            {                
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        year = 366;
                    }
                    else
                    {
                        year = 365;
                    }
                }
                else
                {
                    year = 366;
                }
            }
            else
            {
                year = 365;
            }

            switch (month)
            {
                case 1: return 31;
                case 2 when year == 365: return 28;
                case 2 when year == 366: return 29;  
                case 3: return 31;
                case 4: return 30;
                case 5: return 31;
                case 6: return 30;
                case 7: return 31;
                case 8: return 31;
                case 9: return 30;
                case 10: return 31;
                case 11: return 30;
                case 12: return 31;
                default: return 0;
            }
           
        } 
    }
}
