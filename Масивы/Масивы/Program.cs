using System;

namespace Масивы
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5]; // массив чисел
            string[] names = new string[3] //массив строк
            {
                "George", "Tom", "Andrew"  //указываем что будет в массиве в теле функции
            };
            for (int i = 0; i < names.Length; i++) // черезз цикл фор выводим все варианты
            {
                Console.Write(names[i] + ", "); // выводим массив строк на экран
            }
            //array[0] = 58;
            //array[4] = 5;
            //Console.Write(array[0]);
        }
    }
}
