using System;

namespace Nasledovanie
{
   class Animal
    {
        public string Name { get; set; }
        
        public Animal(string name)
        {
            Name = name;
        }
    
        public void Print()
        {
            Console.WriteLine("Name: " + Name);
        }
    }

    class Dog : Animal
    {
        private float speed;

        public Dog(float speed, string name) : base(name)
        {
            this.speed = speed;
            Console.WriteLine("speed " + speed);
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog tom = new Dog(12.23f, "Tom");
            Console.WriteLine(tom.Name);

            Dog Jery = new Dog(23.2f, "Jery");
            Console.WriteLine(Jery.Name);
            Console.WriteLine();
            Jery.Print();
        }
    }
}
