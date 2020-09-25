using System;

namespace enumPraktick
{
    class Program
    {
        enum Days//Если не указать тип, по дефолту присвоистя int
        {
            Monday,  //0
            Tuesday, //1
            Wednesday, //2
            Thursday, //3 
            Friday = 124, //4
            Saturday, //5
            Sunday //6

        }

        enum Character
        {
            Wizard = 100,
            Figther = 200,
            Thief = 300
        }
        static void Main(string[] args)
        {
            Character Person;
            Person = Character.Figther;
            Console.WriteLine(Character.Wizard);
            Console.WriteLine("Your Person is: {0}", Person);
            Days day;
            day = Days.Friday;
            Console.WriteLine((int)day);
        }
    }
}
