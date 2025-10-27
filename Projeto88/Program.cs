using System;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myfolder\file1.txt";

            System.Console.WriteLine(Path.DirectorySeparatorChar);
            System.Console.WriteLine(Path.PathSeparator);
            System.Console.WriteLine(Path.GetDirectoryName);
            System.Console.WriteLine(Path.GetFileName);
            System.Console.WriteLine(Path.GetFileNameWithoutExtension);
            System.Console.WriteLine(Path.GetExtension);
            System.Console.WriteLine(Path.GetFullPath(path));
            System.Console.WriteLine(Path.GetTempPath);
        }
    }
}