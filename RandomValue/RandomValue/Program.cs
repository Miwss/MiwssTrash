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

            var random = new Random();

            //случайные числа
            for (int i = 0; i < 10; i++)
                Console.WriteLine(random.Next());

            //случайные числа с ограничением
            for (int i = 0; i < 10; i++)
                Console.WriteLine(random.Next(1, 100));

            //случайные маленькие буквы 
            for (int i = 0; i < 10; i++)
                Console.Write((char)random.Next(97, 122));


            Console.WriteLine("\n");

            //случайные большие буквы 
            for (int i = 0; i < 10; i++)
                Console.Write((char)random.Next(65, 90));
            //Console.ReadKey();

            Console.WriteLine("\n");


            //Тест на байты и остальные значения
            for (int i = 0; i < 10; i++)
                Console.WriteLine(random.Next());
        }
    }

}
