using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите А:");
            float A = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите B:");
            float B = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите C:");
            float C = Convert.ToSingle(Console.ReadLine());

            float Bh = Math.Abs(A - B);
            float Ch = Math.Abs(A - C);

            if (Bh < Ch)
            {
                Console.WriteLine("Ответ:{0}", Bh);
            }
            else if (Ch < Bh) 
            {
               
                Console.WriteLine("Ответ:{0}",Ch);
            }
            else if (Ch == Bh)
            {

                Console.WriteLine(" Точки B и C удалены от точки А на :{0}", Ch);
            }
            Console.Read();
        }
    }
}
