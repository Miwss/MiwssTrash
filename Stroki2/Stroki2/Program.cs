using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            string name = "Yuri";
            string surname = "Zolotarevo";
            string whiteSpace = "   Yuri";

            //перевод формата строки в заглавные
            Console.WriteLine(name.ToUpper());

            //перевод формата строки в малые
            Console.WriteLine(name.ToLower());

            //убираем white space
            Console.WriteLine(whiteSpace);
            Console.WriteLine(whiteSpace.Trim());

            //ищем индекс буквы
            Console.WriteLine(surname.IndexOf('o')); //вернет индекс первой попавшейся буквы
            Console.WriteLine(surname.LastIndexOf('o'));
            Console.WriteLine(surname.IndexOf("olot")); //индекс первой буквы

            //substrings
            var moscow = "Москва большой город.";
            var bigCity = moscow.Substring(7, 7);
            Console.WriteLine(bigCity);

            string x = null; //null
            string y = "";  //empty
            string h = "    "; //whitespace

            if (String.IsNullOrEmpty(moscow))
                Console.WriteLine("no moscow");

            if (String.IsNullOrWhiteSpace(moscow))
                Console.WriteLine("no moscow");

            //split
            var splitted = moscow.Split(' ');
            foreach (var i in splitted)
            {
                Console.WriteLine(i);
            }

            //коневертация
            string s = "12345";
            int another = Convert.ToInt32(s); //если s равно нулю или пусто то вернет default 0 БЕЗОПАСНО
            int number = int.Parse(s); //в случае если s ноль или пусто то выкенет исключение
            string back = another.ToString(); // внутри ToString(формат)
            string formatString = another.ToString("C0"); // $12,345 где 0 = кол-во знаков после запятой
            Console.WriteLine(formatString);
            //форматы format strings
            //C - currency, D - decimal , E - exponential, F - fixed point, X - Hexadecimal



            Console.ReadKey();
        }
    }


}
