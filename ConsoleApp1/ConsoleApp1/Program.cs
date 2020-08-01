using System; //стандартная либа

namespace ConsoleApp1 //Название проекта где работаем
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); //Консоль, метод в котором вызывается задача
            int num = 0;
            float num_2 = 2.6f; //
            char sym = 'H';
            string str = "Hello";
            bool isHappy = true;


            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello! " + num);
        }
    }
}