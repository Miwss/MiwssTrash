using System;

namespace Функции
{
    class Program
    {
        static void Main(string[] args)//masiv iz strok
        {
            Print("Hi");
            int num;
            num = sum(4, 10);
            Print(num);

        }

        public static void Print(string str)
        {
            Console.WriteLine(str);
        }
        public static void Print(int num)
        {
            Console.WriteLine(num);
        }
        public static int sum(int a, int b)
        {
            int res;
            res = a + b;
            return res;
        }
    }
}
