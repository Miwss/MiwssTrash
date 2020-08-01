using System;

namespace switchq
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5, b = 0;
            switch (n)
            {
                case 1:
                    b = 5;
                    break;
                case 2:
                    b = 10;
                    break;
                case 3:
                    b = 15;
                    break;
                case 4:
                    b = 20;
                    Console.WriteLine("hi");
                    break;
                default: //выполняется если все остальные кейсы не сработали! Как else в условных операторах
                    b = 5;
                    Console.WriteLine("Hello World!");
                    break;
            }
            Console.WriteLine(b);
        }
    }
}
