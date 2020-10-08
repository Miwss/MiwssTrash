using System;
using System.Linq;

namespace test3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Рандомный текст для проверки проги.,,,,,,:";
           // text = text.Trim(new char[] { ',','.' });
            string[] textArray = text.Split(new char[] {' '});
            Console.WriteLine("Количество слов с строке: " + textArray.Length);
        }
    }
}
