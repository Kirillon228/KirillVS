using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ширину: ");
            float Width = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите длинну: ");
            float Long = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите высоту: ");
            float Height = Convert.ToSingle(Console.ReadLine());

            float Volume = Width * Long * Height;

            float SurfaceArea = 2 * (Width * Long + Long * Height + Height * Width);

            Console.WriteLine("Вот ваш первый гребаный ответ :{0}", Volume);
            Console.WriteLine("Вот ваш второй гребаный ответ :{0}", SurfaceArea);

            Console.Read();




        }
    }
}
