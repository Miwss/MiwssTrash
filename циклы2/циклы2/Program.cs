using System;

namespace циклы2
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[] names = { "Artem", "Sasha", "Vanya" };

            //  foreach(var person in names)
            // {
            //        Console.WriteLine("{0}"person);
            //    }
            string myChoice;
            do
            {
                //Print A menu
                Console.WriteLine("My address Book\n");
                Console.WriteLine("A - Add new Address");
                Console.WriteLine("D - Delete Address");
                Console.WriteLine("M - Modify Address");
                Console.WriteLine("v - View Addresses");
                Console.WriteLine("Q - Quit\n");

                Console.WriteLine("Choice (A,D,M,V, or Q): ");

                //Retrieve the user's choice
                myChoice = Console.ReadLine();

                //Make a decision based on the user's choice
                switch (myChoice)
                {
                    case "A":
                    case "a":
                        Console.WriteLine("You wish to add an address.");
                        break;
                    case "D":
                    case "d":
                        Console.WriteLine("You wish to delete an address.");
                        break;
                    case "M":
                    case "m":
                        Console.WriteLine("You wish to modify an address.");
                        break;
                    case "V":
                    case "v":
                        Console.WriteLine("You wish to view the address list.");
                        break;
                    case "Q":
                    case "q":
                        Console.WriteLine("Bye.");
                        break;
                    default:
                        Console.WriteLine("{0} is not a valid choice", myChoice);
                        break;
                }
                //Pause to allow the user to see the result
                Console.Write("press Enter key to continue...");
                Console.ReadLine();
                Console.WriteLine();
            }
                 while (myChoice != "Q" && myChoice != "q"); // repeat until 
        }
    }
}
