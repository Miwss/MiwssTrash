using System;
using System.Linq;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] myInts = { 5, 10, 4 };
            // bool[][] myBools = new bool[2][];
            // myBools[0] = new bool[2];
            // myBools[1] = new bool[1];
            //  double[,] myDoubles = new double[2, 2];
            //  string[] myStrings = new string[3];
            //  var j = myInts;
            //  for (int i = 0; i <= myInts.Length; i++)
            //  {
            //      Console.WriteLine(i);
            //   }
            // Console.WriteLine(j);
            // Console.WriteLine("myInts[0]: {0}, myInts[1]: {1}, myInts[2]: {2}", myInts[0], myInts[1], myInts[2]);
           
            int[] A;
            int[] b = Enumerable.Repeat(5, 10).ToArray();
            for (int j = 0; j < b.Length; j++)
            {
                Console.Write(b[j]+ "\n");
            }
            A = new int[] {1,2,3,4,5,6,7,8,9 };

            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i]);
            }
        }
    }
}
