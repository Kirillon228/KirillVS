using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите направление от 0 до 3:");
            int C = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите направление от -1 до 1:");
            int N = Convert.ToInt32(Console.ReadLine());

            int B = C + N;

            if (B >= -1 && B <= 3)
            {
                switch (B)
                {
                    case 0:
                            Console.WriteLine("Север");
                        break;

                    case 1:
                        
                            Console.WriteLine("Запад");
                        break;

                    case 2:
                       
                            Console.WriteLine("Юг");
                        break;

                    case -1:
                        
                            Console.WriteLine("Восток");
                        break;

                    case 3:

                        Console.WriteLine("Восток");
                        break;



                }
                
                            

            }
            else
            {
                Console.WriteLine("Север");
            }
            Console.Read();
        }
    }
}
