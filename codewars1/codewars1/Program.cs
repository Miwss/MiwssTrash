using System;
using System.Linq;
using System.Text;

namespace codewars1
{
    class Program
    {
        static void Main(string[] args)
        {

            var jh = (firstName: "artem", lastName: "Anisrtai", born: 1999, published: 1234);

            string back = "hello world";

            for (int i = 0; i < back.Length; i++)
            {
                Console.Write(back[back.Length - i - 1]);
            }

            Console.WriteLine($"{jh.firstName} \n {jh.lastName} \n {Math.Round((2019d - jh.born) / 100d) * 100d}");
            /*string str;
            str = Console.ReadLine();
            char[] sReverse = str.ToCharArray();
            Array.Reverse(sReverse);
            str = new string(sReverse);
                */
            //for(int i = 0; i < str.Length; i++)
            //ReverseStringBuilder("qwe");
            Console.WriteLine(ReverseStringBuilder("qwe"));
            

        }
        public static string ReverseStringBuilder(string str)
        {
            StringBuilder sb = new StringBuilder(str.Length);

            for (int i = str.Length; i-- != 0;)
                sb.Append(str[i]);
            return sb.ToString();
        }
    }
}

