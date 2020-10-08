using System;

namespace заполнениеДвумерныхМассивовСклавиатуры
{
    class Program
    {
        static void Main(string[] args)
        {
            //  int[,] myArray = new int[10,6];
            //  Random random = new Random();
            // for(int i = 0; i < myArray.GetLength(0); i++)
            // {
            //       for(int j = 0; j < myArray.GetLength(1); j++)
            //      {
            // myArray[i, j] = random.Next(100);
            //    }
            //    }
            //
            //   for(int y = 0; y < myArray.GetLength(0); y++)
            //   {
            //       for(int x = 0; x < myArray.GetLength(1); x++)
            //         {
            //              Console.Write(myArray[y, x] + "\t");
            //          }
            //          Console.WriteLine();
            //       }

            //////STROKI///////////////////

            //string[,] myArray = new string[5, 2];

            // for (int i = 0; i < myArray.GetLength(0); i++)
            //{
            //   for (int j = 0; j < myArray.GetLength(1); j++)
            //  {
            //     Console.WriteLine("MMR: "+ i + " NAME: "+ j);
            //    myArray[i, j] = Console.ReadLine();
            // }
            // }
            //Console.WriteLine();

            //            for (int y = 0; y < myArray.GetLength(0); y++)
            //           {
            //              for (int x = 0; x < myArray.GetLength(1); x++)
            //             {
            //                Console.Write(myArray[y, x] + "\t");
            //           }
            //          Console.WriteLine();
            //     }

            ///vvod s klavi///
            //  int[,] myArray1 = new int[2, 3];

            // for(int i = 0; i < myArray1.GetLength(0); i++)
            //{
            //   for(int j = 0; j < myArray1.GetLength(1); j++)
            //  {
            //     Console.WriteLine("Y: " + i + "X: " + j);
            //    myArray1[i, j] = int.Parse(Console.ReadLine());
            // }
            // }

            //for(int x = 0; x < myArray1.GetLength(0); x++)
            //{
            //   for(int y = 0; y < myArray1.GetLength(1); y++)
            // {
            //    Console.Write(myArray1[x,y]+ "\t");
            // }
            // Console.WriteLine();
            // }
            //////////random chisla//////////////
            int[,] rnd = new int[10, 6];
            Random random = new Random();
            for(int i = 0; i < rnd.GetLength(0); i++)
            {
                for(int j = 0; j < rnd.GetLength(1); j++)
                {
                    rnd[i, j] = random.Next(100);
                 
                }
                
            }
            for(int x = 0; x < rnd.GetLength(0); x++)
            {
                for(int y = 0; y < rnd.GetLength(1); y++)
                {
                    Console.Write(rnd[x,y] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
