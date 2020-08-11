using System;
using System.Collections.Generic;

namespace Виртуальные_методы_переопределение_
{
    class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public virtual void Print()
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
            // Console.WriteLine("speed " + speed);
        }
        public override void Print()// переопределение метода
        {

            base.Print();//принимаем базовый метод
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
            base.Print();
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

