using System;

namespace Строки
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Naruto, Saske, Neji";
            //Console.WriteLine(String.IsNullOrEmpty (str));//Показывает является ли строка пустой
            //Console.WriteLine(String.IsNullOrWhiteSpace(str));//данный метод проверяет не только на наличие символов в строке, а так же и на пробелмы в ней

            String.Compare("a", "b"); //вернет -1



            // Console.WriteLine(str.Contains("ll")); //смотрит есть ли в строке данная часть текста
            Console.WriteLine(str.StartsWith("HeLl")); //Проверяет начало строки
            Console.WriteLine(str.EndsWith("llD")); //проверяет конец строки

            Console.WriteLine(str.Insert(5,  "llD")); //тавляет новые данные с строку, по элементу

            Console.WriteLine(str.Remove(5)); //Обрезает строку

            Console.WriteLine(str.Replace("Llo" , "llo")); //меняет значения в строке на которе нам нужно, меняет абсолютно все если есть несколько


            char[] sym = str.ToCharArray();//преображает строку в массив символов чар
            string[] name = str.Split (',');


            Console.WriteLine(name[1]);



        }
    }
}
