using System;
using System.Collections.Generic;
using System.Threading;

namespace ForeachPraktick
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            int sum = 1;

            int[] myArray = new int[3]; // int[] myArray = {12, 14, 15};

            myArray[0] = 12;
            myArray[1] = 14;
            myArray[2] = 15;
            
            foreach(int num in myArray)
            {
                Console.WriteLine( $"Элемент {count} = {num}");
                count++;
            }

            List<int> myList = new List<int> { 1, 2, 3, 4, 5 };
            foreach(int list in myList)
            {
                Console.WriteLine($"Элемент {sum} = {list}");
                sum++;
            }
        }
    }
}
