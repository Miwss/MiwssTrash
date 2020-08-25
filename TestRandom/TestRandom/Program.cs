using System;

namespace TestRandom
{
    class Program
    {
        //Выводим рандомное число и можем записать его куда нам нужно
        static void Main(string[] args)
        {
            Random random = new Random();
            int i = random.Next(1, 5);
            int y = random.Next();
            Console.WriteLine(y);
                Console.WriteLine(i);
            if(i == 4)
            {
                Console.WriteLine("Congratulation!");
            }
            else
            {
                Console.WriteLine("Try again!");
            }
            //int y = i;
            //Console.WriteLine(y);
            rnd();
            rndChar();
        }
        //Рандомная генерация значений
        public static void rnd()
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++) ;
            //Можно задать границы при выводе
            Console.WriteLine(random.Next());

            int y = random.Next();
            Console.WriteLine(y);
        }
        public static void rndChar()
        {
            var random = new Random();
            for (int i = 0; i < 10; i++) ;
            Console.Write((char)random.Next(97, 122));
        }

    }
}
