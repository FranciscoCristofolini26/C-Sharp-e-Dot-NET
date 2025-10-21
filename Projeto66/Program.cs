using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            System.Console.WriteLine(d1);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            System.Console.WriteLine(d2);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);
            System.Console.WriteLine(d3);

            System.Console.WriteLine("d1: " + d1);
            System.Console.WriteLine("d1 Kind: " + d1.Kind);
            System.Console.WriteLine("d1 to Local " + d1.ToLocalTime());
            System.Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            System.Console.WriteLine();
            System.Console.WriteLine("d2: " + d2);
            System.Console.WriteLine("d2 Kind: " + d2.Kind);
            System.Console.WriteLine("d2 to Local " + d2.ToLocalTime());
            System.Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            System.Console.WriteLine();
            System.Console.WriteLine("d3: " + d3);
            System.Console.WriteLine("d3 Kind: " + d3.Kind);
            System.Console.WriteLine("d3 to Local " + d3.ToLocalTime());
            System.Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime());
        }
    }
}