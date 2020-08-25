using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp1
{
    class Ссылочные_типы
    {

        static void Main(string[] args)
        {
            //stack - value types (типы значений)
            int x = 55;
            int y = x;
            y++;
            Console.WriteLine($"{x} {y}");

            //heap - reference types (ссылочные типы)
            var names = new string[] { "Bob", "Yuri" };
            string[] newNames = names;

            var correct = new string[2];
            names.CopyTo(correct, 0);
            correct[1] = "Ricardo";
            newNames[1] = "Ricardo";

            Console.WriteLine($"{names[1]} {newNames[1]} {correct[1]}");




            Console.ReadKey();
        }
    }


}
