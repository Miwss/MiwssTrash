using System;

namespace ObrabotchikIsklycheniy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Num is - " + num); 
            }
            catch (FormatException)
            {
                Console.WriteLine("ErrorFormat");
                throw;
            }
        }
    }
}
