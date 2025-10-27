using System;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\temp\file1.txt";
            string targetPath = @"C:\temp\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    System.Console.WriteLine(line);
                }
            } catch (IOException e)
            {
                System.Console.WriteLine("an error ocurred"); 
                System.Console.WriteLine(e.Message); 

            }
        }
    }
}