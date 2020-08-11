using System;

namespace Перечисление_enum
{
    enum Breed { Dog, Cat, Bird, Bear, Tiger };
    class Animal
    {
        public Breed breed;

        public Animal (Breed breed)
        {
            this.breed = breed;
        }

        public void Print()
        {
            Console.WriteLine(breed);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal(Breed.Bird);
            dog.Print();
        }
    }
}
