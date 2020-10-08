using System;
using System.Dynamic;

namespace ОператорУправленияОбчыслювальнымПроцессом
{
    //else if and multicase
    class Program
    {
        static void Main(string[] args)
        {
            string myInput;
            int myInt;

            Console.WriteLine("Enter random number: ");
            myInput = Console.ReadLine();
            myInt = int.Parse(myInput);
            if (myInt > 0)
                Console.WriteLine("Your number {0} is greater than zero.", myInt);
            if (myInt < 0)
                Console.WriteLine("Your number {0} is less than zero.", myInt);
            if(myInt != 0)
                Console.WriteLine("Your number {0} is not equal to zero.", myInt);
            else
                Console.WriteLine("Your number {0} is equal to zero.", myInt);
            // Multiple Case Decision
            if (myInt < 0 || myInt ==0)
            {
                Console.WriteLine("Your number {0} is less than or equal to zero.", myInt);
            }
            else if (myInt > 0 && myInt <= 10)
            {
                Console.WriteLine("Your number {0} is in the rang from 1 to 10.", myInt);
            }
            else if(myInt > 10 && myInt <= 20)
            {
                Console.WriteLine("Your number {0} is in the range from 11 to 20.", myInt);
            }
            else if(myInt > 20 && myInt <= 30)
            {
                Console.WriteLine("Your number {0} is the rang in the from 21 to 30", myInt);
            }
            else
            {
                Console.WriteLine("Your number {0} is greater than 30.", myInt);
            }
            Console.ReadKey();
        }
    }
}
