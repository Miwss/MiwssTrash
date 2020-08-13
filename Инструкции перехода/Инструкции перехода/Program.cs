using System;

namespace Инструкции_перехода
{
    class Program
    {
        //инструкции перехода
        //break - выход из цикла 
        //continue - при выполнении условия, переходим на следующею итерацию, остальные методы вызыватся не будут
        //return
        //goto
        static void Main(string[] args)
        {
            if (true)
            {
                Example();
            }

            


            for(int i = 0; i < 10; i++)
            {
                if(i >= 5)
                
                   break;
                    Console.WriteLine(i + "\n");
                
            }
            Console.WriteLine();
        }
        public static void Example()
        {
            for(int j = 0; j < 5; j++)
            {
                if (j > 2) return;

                Console.WriteLine(j);
            }
        }
    }
}
