using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите день:");
            int D = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите месяц:");
            int M = Convert.ToInt32(Console.ReadLine());
                       
            switch (M)
            {
                case 1 when D >= 20 && D <= 31:
                case 2 when D >= 1 && D <= 18:
                    Console.WriteLine("Водолей");
                    break;
                case 2 when D >= 19 && D <= 28:
                case 3 when D >= 1 && D <= 20:
                    Console.WriteLine("Рыбы");
                    break;
                case 3 when D >= 21 && D <= 31:
                case 4 when D >= 1 && D <= 19:
                    Console.WriteLine("Овен");
                    break;
                case 4 when D >= 20 && D <= 30:
                case 5 when D >= 1 && D <= 20:
                    Console.WriteLine("Телец");
                    break;
                case 5 when D >= 21 && D <= 31:
                case 6 when D >= 1 && D <= 21:
                    Console.WriteLine("Близнецы");
                    break;
                case 6 when D >= 22 && D <= 30:
                case 7 when D >= 1 && D <= 22:
                    Console.WriteLine("Рак");
                    break;
                case 7 when D >= 23 && D <= 31:
                case 8 when D >= 1 && D <= 22:
                    Console.WriteLine("Лев");
                    break;
                case 8 when D >= 23 && D <= 31:
                case 9 when D >= 1 && D <= 22:
                    Console.WriteLine("Дева");
                    break;
                case 9 when D >= 23 && D <= 30:
                case 10 when D >= 1 && D <= 22:
                    Console.WriteLine("Весы");
                    break;
                case 10 when D >= 23 && D <= 31:
                case 11 when D >= 1 && D <= 22:
                    Console.WriteLine("Скорпион");
                    break;
                case 11 when D >= 23 && D <= 30:
                case 12 when D >= 1 && D <= 21:
                    Console.WriteLine("Стрелец");
                    break;
                case 12 when D >= 22 && D <= 31:
                case 1 when D >= 1 && D <= 19:
                    Console.WriteLine("Козерог");
                    break;

            }
            Console.Read();
        }
    }
}
