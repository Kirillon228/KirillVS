using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите процент:");
            float p = Convert.ToSingle(Console.ReadLine());

            int k = 1;
            float b = 1000;
            
            while ((p  / 100) * b + b <= 1100)  
            {
                b = b + (p / 100) * b;
                k = k + 1;
            }
            Console.WriteLine($"Всего месяцев:{k}");
            Console.WriteLine($"Всего рублей:{ b + (p / 100) * b}");

            Console.Read();
        }
    }
}
