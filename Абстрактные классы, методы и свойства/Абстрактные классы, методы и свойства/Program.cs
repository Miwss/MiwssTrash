using System;
using System.Collections.Generic;

namespace Абстрактные_классы__методы_и_свойства
{
    abstract class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract void Print();

    }

    class Dog : Animal
    {
        private float speed;

        public Dog(float speed, string name) : base(name)
        {
            this.speed = speed;
            // Console.WriteLine("speed " + speed);
        }
        public override void Print()// переопределение метода
        {

            Console.WriteLine("Dog Speed: " + speed);
        }

    }

    class Cat : Animal
    {
        private float speed;

        public Cat(float speed, string name) : base(name)
        {
            this.speed = speed;
            // Console.WriteLine("speed " + speed);
        }
        public override void Print()
        {
            Console.WriteLine("Cat Speed: " + speed);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animal = new List<Animal>();
            animal.Add(new Dog(12.23f, "Alex"));
            animal.Add(new Dog(12.24f, "Tom"));
            animal.Add(new Cat(12.25f, "Meow"));

            foreach (Animal animals in animal)
            {
                animals.Print();   //вызываем метод
            }
        }
    }
}