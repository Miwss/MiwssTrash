using System;

namespace OOOOPPPP
{
    class Animal
    {
        public static int count = 0;

        public string name;
        public int age;
        public float hapines;

        public Animal()
        {
            name = "Spotty";
            age = 7;
            hapines = 0.7f;

            count++;
            Print();
        }
        public Animal(string _name, int _age, float _hapiness)
        {
            name = _name;
            age = _age;
            hapines = _hapiness;

            count++;
            Print();
        }


        public void Print()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Hapiness: " + hapines);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Animal cat = new Animal();
            Console.WriteLine();

            Animal dog = new Animal("George", 5, 0.9f);
        }
    }
}
