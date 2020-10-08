using System;

namespace СтупенчатыеМассивый
{
    class Program
    {
        static void Main(string[] args)
        {
            //   int[][] myArray = new int [3][];
            // myArray[0] = new int[5];
            //myArray[1] = new int[2];
            //myArray[2] = new int[10];

            //   Random random = new Random();

            //   for(int i = 0; i < myArray.Length; i++)
            //  {
            //     for(int j = 0; j < myArray[i].Length; j++)
            //    {
            //       myArray[i][j] = random.Next(100);
            //  }
            ///  }
            // for(int i = 0; i < myArray.Length; i++)
            //{
            //   for(int j = 0; j < myArray[i].Length; j++)
            //  {
            //     Console.Write(myArray[i][j] + "\t");
            // }
            // Console.WriteLine();
            //}
            string[][] myArray = new string[3][];
            myArray[0] = new string[3];
            myArray[1] = new string[5];
            myArray[2] = new string[1];

            for (int i = 0; i < myArray.Length; i++)
            {
                for(int j = 0; j<myArray[i].Length; j++)
                {
                    Console.WriteLine("Enter each name: ");
                    myArray[i][j] = Console.ReadLine();
                }
                Console.WriteLine();
            }
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write(myArray[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
