using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d2 = DateTime.Parse("2000-08-15T13:0:58Z");
            System.Console.WriteLine("d1: " + d1);
            System.Console.WriteLine("d1 Kind: " + d1.Kind);
            System.Console.WriteLine("d1 to Local " + d1.ToLocalTime());
            System.Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            System.Console.WriteLine();
            System.Console.WriteLine("d2: " + d2);
            System.Console.WriteLine("d2 Kind: " + d2.Kind);
            System.Console.WriteLine("d2 to Local " + d2.ToLocalTime());
            System.Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
        }
    }
}