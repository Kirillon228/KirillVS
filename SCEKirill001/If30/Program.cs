using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число от 1 до 999:");
            int Number = Convert.ToInt32(Console.ReadLine());

            int a = Number % 2;

            if (Number >= 100)
            {

                if (a == 0)
                {
                    Console.WriteLine("Четное трехзначное");
                }
                else
                {
                    Console.WriteLine("Нечетное трехзначное");
                }
            }
            else if (Number > 10)
            {
                if (a == 0)
                {
                    Console.WriteLine("Четное двухзначное");
                }
                else
                {
                    Console.WriteLine("Нечетное двухзначное");
                }

            }
            else if (Number <= 9)
            {
                if (a == 0)
                {
                    Console.WriteLine("Четная цифра");
                }
                else
                {
                    Console.WriteLine("Нечетная цифра");
                }
            }
            Console.Read();
        }
    }
}