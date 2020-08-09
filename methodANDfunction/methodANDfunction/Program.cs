using System;

namespace methodANDfunction
{
    class Program
    {
        static void Main(string[] args) // это метод мейн
        {
            WriteHello("Hello");
            int num = Convert.ToInt32(Console.ReadLine());
            int num_2 =  Convert.ToInt32(Console.ReadLine());
            //Add(num, num_2);
            int result = Add(num, num_2);
            Console.WriteLine("result is " + result);
        }
        public static void WriteHello(string str)// в скобках это параметры
        {
            Console.WriteLine(str);
        }
        //public static void Add(int num_1, int num_2) первый способ записи с выводом в мейне
       // {
       //     Console.WriteLine("result is " + (num_1 + num_2));
      //  }
        public static int Add(int num_1, int num_2) //вторая форма, где функция сразу возвращает результат
        {
            return num_1 * num_2;
        }
    }
}
