using System;

namespace Структуры
{
    struct Book
    {
        public string title;
        public string name;
        public string author;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book b;
            b.author = "King";
            Console.WriteLine(b.author);
        }
    }
}
