using System;

namespace Условные_операторы_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            Console.WriteLine("How old are you?");
            num = Convert.ToDouble(Console.ReadLine());

            if (num > 18.23d && num < 20)
                Console.WriteLine("Your are older than 18.23");
            else if (num < 10)
                Console.WriteLine("under 10");
            else
                Console.WriteLine("Else");

            string name = num == 15 ? "First" : "Second";//Если нейм = 15 то выведет Ферст если нет то Секонд!(Такая вль фоома записи)
            Console.WriteLine(name);
            Console.ReadKey();
        }
    }
}
