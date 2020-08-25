using System;
using System.Text;

namespace SB
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Artem";
            string surname = "Anistrai";

            var myString = new StringBuilder();
            myString.Append("Artem Anistrai");
            myString.Replace('a', 'o');
            myString.Replace('i', 'a');

            Console.WriteLine(myString);
        }
    }
}
