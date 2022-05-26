using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proc50
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Введите время:");
                int time = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(TimeToHMS(time));
            }
            Console.Read();
        }
        private static (int, int, int) TimeToHMS(int time)
        {
            int seconds = 0;
            int minutes = 0;
            int hour = 0;
            for (int i = 0; time != 0; i++)
            {
                if (time >= 3600)
                {
                    time = time - 3600;

                    hour++;
                }
                else if (time >= 60)
                {
                    time -= 60;
                    minutes++;
                }
                else
                {
                    seconds = time;
                    time = 0;
                }
            }
            return (hour, minutes, seconds);       
        }
    }
}
