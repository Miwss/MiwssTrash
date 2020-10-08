using System;

namespace practick_switchПереключателей
{
    class Program
    {
        static void Main(string[] args)
        {
            string myInput;
            int myInt;

        begin:

            Console.WriteLine("Please enter a number between 1 and 3: ");
            myInput = Console.ReadLine();
            myInt = int.Parse(myInput);

            switch (myInt)
            {
                case 1:
                    Console.WriteLine("Your number is {0}.", myInt);
                    break;
                case 2:
                    Console.WriteLine("Your number is {0}.", myInt);
                    break;
                case 3:
                    Console.WriteLine("your number is {0}", myInt);
                    break;
                default:
                    Console.WriteLine("Number {0} not between 1 or 3.", myInt);
                    break;
            }

        decide:

            Console.WriteLine("Type \"continue\" to go on or \"quite\" to stop: ");
            myInput = Console.ReadLine();

            switch (myInput)
            {
                case "continue":
                    goto begin;
                case "quite":
                    Console.WriteLine("Bye.");
                    break;
                default:
                    Console.WriteLine("Your input {0} is incorrect.", myInput);
                    goto decide;
            }
        }
    }
}
