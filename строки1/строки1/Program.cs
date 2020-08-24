using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    class Program
    { static void Main(string[] args)
        {
            string name = "Yuri";
            string surname = "Zolotarev";

            //сращивание строки concatination
            string fullName = name + " " + surname;
            string myFullName = string.Format("{0} {1}", name, surname);
            string myFinalName = $"{name} {surname}";

            Console.WriteLine(myFinalName);

            int[] array = { 1, 5, 7, 99 };
            string list = string.Join(";", array);
            Console.WriteLine("List: " + list);

            /*int[] array1 = { 4, 4, 9, 99 };
            string list1 = string.Join(":", array1);
            Console.WriteLine("List: " + list1);*/

            string[] array2 = { "Artem", "Sasha", "Leha" };
            string list2 = string.Join(": ", array2);
            for (int i = 0; i < array2.Length; i++)
                Console.WriteLine(array2[i]);
                
            char initialName = name[0];
            char initialSurname = surname[0];
            Console.WriteLine($"Initials: {initialName}{initialSurname}");

            //name[0] = 'q'; нельзя поменять отдельные буквы

            string newLine = "Hello, \n my name is Yuri";
            string newLineEnvironment = "Hello" + Environment.NewLine + "my name is Yuri.";
            Console.WriteLine("New Line Example");
            Console.WriteLine(newLine);
            Console.WriteLine(newLineEnvironment);

            Console.WriteLine("Tab Example");
            string tab = "Hello, \t \t \t my name is Yuri";
            Console.WriteLine(tab);

            Console.WriteLine("Другие");
            string other = "\'Hello, \\ my name is Yuri\"";
            Console.WriteLine(other);

            Console.WriteLine("Paths Verbatim Strings");
            string pathMessy = "c:\\programfiles\\myprogram\\good";
            string path = @"c:\programfiles\myprogram\good";
            Console.WriteLine(path);

          // Console.ReadKey();
        }
    }


}
