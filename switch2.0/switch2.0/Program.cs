using System;

namespace switchqq2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            Random randNum = new Random();

            num = randNum.Next(1, 6);
            switch (num)
            {
                case 1:
                    Console.WriteLine("Num is - " + num);
                    break;
                case 2:
                    Console.WriteLine("Num is equal to: " + num);
                    break;
                default:
                    Console.WriteLine("Nothing! " + num);
                    break;
            }
        }
    }
}
