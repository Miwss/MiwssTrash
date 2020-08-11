using System;

namespace OOOOPPPP
{
    class Animal
    {
        public static int count = 0;

        public string name;
        public int age;
        public float hapines;

        public Animal()//konstryktor который выводит указанную информациюв переменных, если мы не указываем ее в мейне, вызывается именно он
        {
            name = "Spotty";
            age = 7;
            hapines = 0.7f;

            count++;
            Print();//Вызываем функцию принт 
        }
        public Animal(string _name, int _age, float _hapiness)//konstryktor который принимает значения которые мы конкретно указываем в мейне, вызывается именно он
        {
            name = _name;// подчеркивание снизу вводится для того, что бы изменить имя новой переменной в которую будет записана информация, таким образом мы можем ввести свои данные в мейне
            age = _age;
            hapines = _hapiness;

            count++;
            Print();// вызываем функцию принт
        }


        public void Print()//function na vuvod na ekran
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
