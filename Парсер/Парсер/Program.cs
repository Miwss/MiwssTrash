using System;
using System.CodeDom;
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
            var files = Directory.GetFiles(@"c:\Intel\", "*.*", SearchOption.AllDirectories);

            Console.WriteLine("FILES");
            foreach (var file in files)
            {
                Console.WriteLine(file);
                Console.WriteLine(Path.GetFileName(file));
                Console.WriteLine(Path.GetExtension(file));
                Console.WriteLine(Path.GetFileNameWithoutExtension(file));
            }

            var direc = Directory.GetDirectories(@"c:\Intel\", "*.*", SearchOption.AllDirectories);

            Console.WriteLine("DIRECTORIES");
            foreach (var dir in direc)
            {
                Console.WriteLine(dir);
            }

            var dirInfo = new DirectoryInfo(@"c:\Intel\");
            var dirs = dirInfo.GetDirectories();
            var myFiles = dirInfo.GetFiles("*.*", SearchOption.AllDirectories);

            Console.WriteLine("DIRECTORIES FROM DIRINFO");
            foreach (var myDir in dirs)
            {
                Console.WriteLine(myDir);
            }

            Console.WriteLine("FILES FROM DIRINFO");
            foreach (var fil in myFiles)
            {
                Console.WriteLine(fil);
            }

            Console.ReadKey();

        }

    }

}
