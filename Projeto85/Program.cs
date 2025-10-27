using System;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file1.txt";

            try
            {
            
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        System.Console.WriteLine(line);
                    }
                }
                
            }
            catch (IOException e)
            {
                System.Console.WriteLine("an error ocurred");
                System.Console.WriteLine(e.Message);
            }
            
        }
    }
}