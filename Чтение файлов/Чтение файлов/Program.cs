using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {

            //WriteReadLogStatic();
            WriteReadLogInstance();

            Console.ReadKey();
        }

        private static void WriteReadLogInstance()
        {
            var file = new FileInfo("newLog.txt");

            if (file.Exists)
            {
                Console.WriteLine("File exists!");

                var s = file.AppendText();
                s.WriteAsync(DateTime.Now + " Log message. " + Environment.NewLine);
                s.Dispose();

                using (var stream = file.AppendText())
                {
                    stream.WriteAsync(DateTime.Now + " Log message 2. " + Environment.NewLine);
                }


                using (var textInFile = file.OpenText())
                {
                    var text = textInFile.ReadToEnd();
                    Console.WriteLine("From file text: " + text);
                }
            }
            else
            {
                file.Create();
            }
        }

        private static void WriteReadLogStatic()
        {
            if (File.Exists("log.txt"))
            {
                Console.WriteLine("File exists!");
                File.AppendAllText("log.txt", DateTime.Now + " Log message" + Environment.NewLine);
                var textInFile = File.ReadAllText("log.txt");
                Console.WriteLine(textInFile);
            }
            else
            {
                File.AppendAllText("log.txt", DateTime.Now + " Log message" + Environment.NewLine);
            }
        }

    }

}
