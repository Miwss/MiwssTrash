using System;

namespace массив2
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] nums = { 1.23f, 5.32f, 7.56f };

            foreach (float el in nums)//Форич для работы с массивами, проходится по всему масиву
            {
                Console.WriteLine("Element is: " + el);
            }
        }
    }
}
