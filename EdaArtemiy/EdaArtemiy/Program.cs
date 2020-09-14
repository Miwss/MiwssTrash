using System;

namespace EdaArtemiy
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] ChooseFood = { "Лапша", "Суши", "Пицца", "Грузия", "Бургер", "Домашняя еда", "Салат" };
            int Food = rnd.Next(ChooseFood.Length);
            Console.WriteLine("Сегодня кушаем: {0}", ChooseFood[Food]);
        }
    }
}
