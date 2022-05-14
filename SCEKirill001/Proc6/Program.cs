using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proc6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите числа:");
                int k = Convert.ToInt32(Console.ReadLine());

                int DigitCount = 0;
                int SumDigit = 0;

                (DigitCount, SumDigit) = DigitCountSum(k);

                Console.WriteLine($"Сумма чисел равна:{SumDigit}\nКоличество чисел:{DigitCount}\n");
                Console.Write("Продолжить работу программы? [0] => No, [1] => Yes\nВаш ответ: ");
                int answer = Convert.ToInt32(Console.ReadLine());

                if (answer != 1)
                {
                    Console.WriteLine("Конец программы");
                    Console.Read();
                    break;
                }
            }

        }
        private static (int, int) DigitCountSum(int Number)
        {
            int DigitCount = 0;
            int SumDigit = 0;

            while (Number > 0)
            {
                SumDigit += Number % 10;
                DigitCount++;
                Number /= 10;
            }

            return (DigitCount, SumDigit);
            
        }
    }
}
