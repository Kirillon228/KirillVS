using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integr20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ввести в секундах:");
            uint Seconds = Convert.ToUInt32(Console.ReadLine());

            uint hours = Seconds / 3600;

            Console.WriteLine("Ответ:{0}", hours);

            Console.Read();

        }
    }
}
