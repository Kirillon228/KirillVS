using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите А1:");
            float A = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите B1:");
            float B = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите C1:");
            float C = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите А2:");
            float AA = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите B2:");
            float BB = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите C2:");
            float CC = Convert.ToSingle(Console.ReadLine());

            float D = A * BB - AA * B;

            float X = (C * BB - CC * B) / D;

            float Y = (A * CC - AA * C) / D;

            Console.WriteLine("X= {0}", X);
            Console.WriteLine("Y= {0}", Y);

            Console.Read();

        }
    }
}
