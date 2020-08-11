using System;

namespace Интерфейсы
{
    interface ISOomeInterface
    {
        int property { get; set; }

        void Print();
    }

    interface IDraw
    {   
        void Draw();
    }



    class Test : ISOomeInterface, IDraw
    {
        public int property { get; set; }
        public void Print()
        {
            Console.WriteLine("Some text");
        }
        public void Draw()
        {
            Console.WriteLine("This is pictures");
        }
    }

    class Test2 : ISOomeInterface
    {
        public int property { get; set; }
        public void Print()
        {
            Console.WriteLine("This is text 2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test test_1 = new Test();
            Test2 test_2 = new Test2();
            test_1.property = 12;
            test_1.Print();
            test_1.Draw();
            Console.WriteLine(test_1.property);


            test_2.property = 15;
            test_2.Print();
            Console.WriteLine(test_2.property);
        }
    }
}
