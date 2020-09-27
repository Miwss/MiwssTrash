using System;
using System.Security.Cryptography.X509Certificates;

namespace testtest
{
    class Program
    {
        static void Main(string[] args)
        {
            Text(); 
        }
        public static void Text()
        {
            
            string[] text = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            for (int i = text.GetLowerBound(0); i <= text.GetUpperBound(0); i++)
                Console.WriteLine("{0}: {1}", i + 1, text[i]);
        }
    }
}
