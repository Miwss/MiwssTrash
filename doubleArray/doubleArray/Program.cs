using System;

namespace doubleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] myArray = new int[,]
            //{
            //  {2,1,3,4,5, },
            //{123,4,1,24,12},
            //{31,12,3,2,1 },
            //{123,321,4124,14,213}
            // };
            //foreach(var item in myArray)
            //{
            //  Console.Write(item + " " );
            //}
            //rank/GetLength
            int[,] myArray = new int[,]
            {
                {2,1,3,4,5, },
                {123,4,1,24,12},
                {31,12,3,2,1 },
                {123,321,4124,14,213}
            };
            int height = myArray.GetLength(0);
            int width = myArray.GetLength(1);

            for(int i = 0; i < height; i++)
            {
                for(int j = 0; j< width; j++)
                {
                    Console.Write(myArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
