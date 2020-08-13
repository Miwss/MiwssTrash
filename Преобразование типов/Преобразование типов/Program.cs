using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Преобразование_типов
{
    class Program
    {

        static int x;
        static double y = 10.09D;
        static double z = 2.98D;
        static void Main(string[] args)
        {
            x = (int)(y / z);

            Console.WriteLine("x - " + x);
        }
    }
}
