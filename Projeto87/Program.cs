using System;
using System.IO;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myfolder";

            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                System.Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    System.Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                System.Console.WriteLine("FILES:");
                foreach (string s in files)
                {
                    System.Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + "\\newfolder");
            }
            catch (IOException e)
            {
                System.Console.WriteLine("An error ocurred");
                System.Console.WriteLine(e.Message);
            }
        }
    }
}