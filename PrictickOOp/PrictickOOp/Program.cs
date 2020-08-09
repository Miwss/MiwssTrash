using System;
using System.Numerics;

namespace Massivu
{
    class mainClass
    {
        public static void Main(string[] args)
        {
            int length = 10;
            int [,] numbers = new int [length,length];

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    numbers[i, j] = i + j;
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
 
}
