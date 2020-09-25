using System;

namespace делигаты
{
    class Program
    {
        delegate void Message();
        delegate int Operation(int x, int y);
        delegate void message2();
        static void Main(string[] args)
        {
            message2 mes1 = Hello;
            mes1 += HowAreYou;
            mes1();
            mes1 -= HowAreYou;
            mes1();
            //Console.WriteLine(mes1);
            Operation del = Add;
            int result = del(5, 5);
            Console.WriteLine(result);
            del = Multiply;
            int resalt = del(5, 5);
            Console.WriteLine(resalt);
            Message mes;
            if(DateTime.Now.Hour < 12)
            {
                mes = GoodMorning;
            }
            else
            {
                mes = GoodEvning;
            }
            mes();
            //Console.WriteLine(mes);
        }

        static public void GoodMorning()
        {
            Console.WriteLine("Good Morning");
        }

        static public void GoodEvning()
        {
            Console.WriteLine("Good Evneng");
        }

        static public int Add(int x, int y)
        {
            return x + y;
        }
        static public int Multiply(int x, int y)
        {
            return x * y;
        }

        static public void Hello()
        {
            Console.WriteLine("Hello");
        }
        static public void HowAreYou()
        {
            Console.WriteLine("How Are you?");
        }
    }

}
