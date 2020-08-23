using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {



        static void Main(string[] args)
        {
            //инициализация массива
            int[] array = new int[3];

            //присваивание значений внутри массива
            array[0] = 1;
            array[1] = 456;
            array[2] = 231;

            //инициализация массива второй способ
            // new int[3] можно не писать
            int[] easyArray = new int[3] { 4, 876, 231 };

            //матрица 4х5 - 4 строки и 5 колонов в каждой строке
            var matrix = new int[4, 5];
            //пример
            var myMatrix = new int[3, 5]
            {
                {1, 1, 1, 1, 1},
                {1, 1, 34, 6, 1},
                {1, 1, 1, 1, 1}
            };

            //достаем значения из матрицы в начале указывая строку потом колонку
            int six = myMatrix[1, 2];
            Console.WriteLine("Matrix value: " + six);

            //3D матрицы
            var threeDMatrix = new int[3, 5, 2];

            //массивы с разным колчеством колонок
            var mainArray = new int[3][];
            mainArray[0] = new int[2];
            mainArray[1] = new int[1];
            mainArray[2] = new int[5];

            var mainEasyArray = new int[3][]
            {
                new int[3] {1,1,1},
                new int[2] {1,1},
                new int[5] {1,27,1,7,1}
            };

            int val = mainEasyArray[2][1];
            Console.WriteLine("Jagged array value: " + val);

            //методы Sort, Length, Clear, Reverse

            //Length
            Console.WriteLine("Length");
            Console.WriteLine(array.Length);

            //IndexOf
            Console.WriteLine("Index of");
            Console.WriteLine(Array.IndexOf(array, 231));

            //Clear
            Console.WriteLine("Clear");
            Array.Clear(array, 0, 1);
            foreach (var n in array)
                Console.WriteLine(n);

            Console.WriteLine("Copy");
            var copyArray = new int[2];
            Array.Copy(array, copyArray, 2);
            foreach (var n in copyArray)
                Console.WriteLine(n);

            Console.WriteLine("Sort");
            Array.Sort(easyArray);
            foreach (var n in easyArray)
                Console.WriteLine(n);

            Console.WriteLine("Reverse");
            Array.Reverse(easyArray);
            foreach (var n in easyArray)
                Console.WriteLine(n);

            Console.ReadKey();
        }
    }


}
