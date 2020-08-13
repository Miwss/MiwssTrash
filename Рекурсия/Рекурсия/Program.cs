using System;

namespace Рекурсия
{
    class Program
    {
        public static int fact(int n)
        {
            int result;
            if (n == 1)
                return 1;
            result = fact(n - 1) * n;
            return result;
        }


        public static int newFact(int j)
        {
            int result1 = 1;
            for (int r = 1; r <= j; r++)
            {
                result1 *= r;
            }

            return result1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial " + fact(10));
            Console.WriteLine("newFactorial " + newFact(10));
        
        }
    }
}
