using System;
using System.Text.Encodings;
using System.IO;

//Доработать!

namespace TestFile_andFiLeInFo
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteReadLogStatic();
        }
        private static void WriteReadLogStatic()
        {
            if (File.Exists("log,txt"))
            {
                Console.WriteLine("File exists!");
                File.ReadAllText("Hello world", "static log file");
                var textInFile = File.ReadAllText("Log.txt");
                Console.WriteLine(textInFile);
            }
            else
            {
                File.Create("Log.txt");
            }   
        }
        /*private static void WriteText(string text)
        {
            File.WriteAllText("log.txt", text);
        }*/
    }
}
