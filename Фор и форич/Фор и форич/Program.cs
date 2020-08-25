using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace фор_и_форич
{
    class Program
    {

        static void Main(string[] args)
        {

            string[] names = { "Yuri", "John", "Sofia" };

            Console.WriteLine("Foreach simple");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("For simple");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            var people = new List<Person>()
            {
                new Person() {Name = "Yuri", Age = 32},
                new Person() {Name = "John", Age = 34},
                new Person() {Name = "Sofia", Age = 37}

            };

            Console.WriteLine("Foreach class");

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }

            Console.WriteLine("For class");

            for (int person = 0; person < people.Count; person++)
            {
                Console.WriteLine($"{people[person].Name} {people[person].Age}");
            }

            Console.ReadKey();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }


}
