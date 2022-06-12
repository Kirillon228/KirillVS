using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array131
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество точек:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите точку B (X):");
            int bX = Convert.ToInt32(Console.ReadLine());


            Console.Write("Введите точку B (Y):");
            int bY = Convert.ToInt32(Console.ReadLine());

            (int,int)[] arrayP = InputArray(n);
            (int C, int Z) = nearstPoint(arrayP, bX, bY);

            Console.WriteLine("Самая близкая точка:");

            OutPutArray(C, Z);
            Console.Read();

        }
        private static (int , int)[] InputArray(int n)
        {
            (int,int)[] arrayP = new (int,int)[n];
            
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите точку X [{i}] => ");
                int X = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Введите точку Y [{i}] => ");
                int Y = Convert.ToInt32(Console.ReadLine());

                arrayP[i] = (X, Y);
            }
            return arrayP;            
        }
        private static (int X, int Y) nearstPoint((int x, int y)[] arrayP, int bX,int bY)
        {
            int BestI = 0;            
            double T = double.MaxValue;           
            for(int i = 0; i < arrayP.Length; i++)
            {
                double R = Math.Sqrt(Math.Pow((bX - arrayP[i].x), 2) + Math.Pow((bY - arrayP[i].y), 2));                
                if (T > R)
                {
                    T = R;
                    BestI = i;
                }
            }
            return arrayP[BestI];
        }
        private static void OutPutArray(int C, int Z)
        {
           
                Console.WriteLine($"({C};{Z})");           
        }
    }
}
