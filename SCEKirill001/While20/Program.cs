using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N:");
            int n = Convert.ToInt32(Console.ReadLine());

            bool c = false; 

            while (n > 0)
            {
                int k = n % 10;

                if (k == 2)
                {
                    c = true;

                    break;
                }

                n = n / 10;

            }
            Console.WriteLine(c);

            Console.Read();
        }
    }
}
