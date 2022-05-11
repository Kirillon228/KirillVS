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

            int terPast = 0;
            int counterPresent = 0;
            int counterFuture = 0;
            int counterNumber = 0;
            bool pass = false;
            int answer = 0;
                     

            for (int i = 1; i <= NumberSet; i++) 
            {
                for (int j = 0; ; j++) 
                {
                    Console.Write("Введите числа:");
                    int Number = Convert.ToInt32(Console.ReadLine());
                   
                    if (Number == 0)
                    {
                        break;
                    }
                                                                              
                }
                if (i % 3 == 1)
                {

                    counterPast = counterNumber;
                }
                else if (i % 3 == 2)
                {
                    counterPresent = counterNumber;
                }
                else if (i % 3 == 0)
                {
                    counterFuture = counterNumber;
                }

                
                 if (counterPast < counterFuture&&
                        counterPast < counterPresent ^
                        counterPast > counterFuture &&
                        counterPast > counterPresent ^
                        counterPresent < counterPast &&
                        counterPresent < counterFuture ^
                        counterPresent > counterPast &&
                        counterPresent > counterFuture ^
                        counterFuture < counterPast &&
                        counterFuture < counterPresent ^
                        counterFuture > counterPast &&
                        counterFuture > counterPresent 
                )
                        
                {
                    NumberSet = answer;
                }


                counterNumber = 0;

                pass = true;
            }
            Console.WriteLine($"Ответ:{answer}");
            Console.Read();
        }
    }
}