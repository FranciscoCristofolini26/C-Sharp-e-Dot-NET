using System;
using System.Xml;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<string> printService = new PrintService<string>();


            System.Console.WriteLine("How many values?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                object x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();
            System.Console.WriteLine("First:" + printService.First());
        }
    }
}