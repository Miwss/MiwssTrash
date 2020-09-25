using System;

namespace testString1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            test("hello");
        }

        public static void test(string str)
        {

            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[str.Length - i - 1]);
            }
        }
    }
}
