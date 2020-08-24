
using System;
using System.Collections.Generic;
using System.Linq;

namespace массивы_и_списки
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[10];
            
                array[0] = "a";
                array[1] = "b";
                array[2] = "c";

            List<int> list = new List<int>();

            list.Add(0);
            list.Add(1);
            list.Add(2);

            for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(i);
                    
                }
                Console.WriteLine(array[0]);
        }
    }
}
