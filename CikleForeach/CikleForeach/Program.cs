using System;

namespace CikleForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] numbers = {1.23f, 23.23f, 23.57f};
            foreach(float el in numbers)
            {
                Console.WriteLine(el);
            }
        }
    }
}
