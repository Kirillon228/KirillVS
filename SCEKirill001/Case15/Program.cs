using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите достоинство карты от 6 до 14:");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите достоинство карты от 1 до 4:");
            int M = Convert.ToInt32(Console.ReadLine());

            string name = null;
            string suit = null;

            switch (N)
            {
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    name = N.ToString();

                break;

                case 11:
                    name = "Валет";
                    break;

                case 12:
                    name = "Дама";
                    break;

                case 13:
                    name = "Король";
                    break;

                case 14:
                    name = "Туз";
                    break;
            }
            switch (M)
            {
                case 1:
                    suit = "Пики";

                    break;

                case 2:
                    suit = "Трефы";

                    break;

                case 3:
                    suit = "Бубны";

                    break;

                case 4:
                    suit = "Червы";

                    break;

            }
            Console.WriteLine("Ответ:{0} {1}", name, suit);
            Console.WriteLine($"Ответ: {name} {suit}");

            Console.Read();
        }
    }
}
