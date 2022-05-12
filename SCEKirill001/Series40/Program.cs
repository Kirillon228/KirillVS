using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите k:");
            int  NumberSet= Convert.ToInt32(Console.ReadLine());
                       
            for (int i = 0; i < NumberSet; i++) 
            {
                Console.Write("Введите числа:");
                int numbers1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите числа:");
                int numbers2 = Convert.ToInt32(Console.ReadLine());

                bool isgrowing = numbers1 < numbers2;
                int answer = 2;
                int answer2 = 0;

                for (int j = 2; ;j++) 
                {
                    Console.Write("Введите числа:");
                    int a = Convert.ToInt32(Console.ReadLine());
                    if (a == 0)
                    {
                        break;
                    }

                    bool isgrowingnow = numbers2 < a;

                    if (isgrowing == isgrowingnow && answer2 == 0) 
                    {
                        answer2 = j-1;
                    }
                    else
                    {
                        answer++;
                    }

                    numbers2 = a;
                    isgrowing = isgrowingnow;
                }
                int c = answer2 == 0 ? answer : answer2;
                Console.WriteLine($"Ответ:{c}");
            }

            Console.Read();
        }
    }
}