using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            int i = 1;
            int x = 10;

            Console.WriteLine("\nWhile \n");

            while (i < 10)
            {
                i++;
                Console.WriteLine(i);
            }

            Console.WriteLine("\nDo While \n");

            do
            {
                x++;
                Console.WriteLine(x);

            } while (x < 10);

            Console.ReadKey();
        }
    }

}
