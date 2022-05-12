using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите числа:");
            int numbers1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите числа:");
            int numbers2 = Convert.ToInt32(Console.ReadLine());

            bool isgrowing = numbers1 < numbers2;
            int answer = 0;

            for (int i = 2; i < number; i++)
            {
                Console.Write("Введите числа:");
                int numbers = Convert.ToInt32(Console.ReadLine());

                bool isgrowingnow = numbers2 < numbers;

                if (isgrowing == isgrowingnow && answer == 0)
                {
                    answer = i;
                }
                numbers2 = numbers;
                isgrowing = isgrowingnow;
            }
            Console.WriteLine($"Ответ:{answer}");
            Console.Read();
        }
    }
}
