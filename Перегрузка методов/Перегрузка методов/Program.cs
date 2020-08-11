using System;

namespace Перегрузка_методов
{
    class Some
    {
        public void Multiply(int a, int b)
        {
            Console.WriteLine("Result is: " + a * b);
        }

        public void Multiply(int a, int b, int c)
        {
            Console.WriteLine("Result is: " + a * b * c);
        }

        public void Multiply(string str)
        {
            Console.WriteLine("Result is: " + str);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Some test = new Some();

            test.Multiply(2, 23, 3);

            test.Multiply(2, 23);

            test.Multiply("Hello");
        }
    }
}
