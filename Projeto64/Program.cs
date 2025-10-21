using System;
using System.Net.Http.Headers;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = DateTime.Now;
            DateTime d2 = d.AddDays(7);

            System.Console.WriteLine(d);
            System.Console.WriteLine(d2);

            DateTime d3 = new DateTime(2000, 10, 15);
            DateTime d4 = new DateTime(2000, 10, 18);

            System.Console.WriteLine(d3);
            System.Console.WriteLine(d4);

            TimeSpan t = d4.Subtract(d3);

            System.Console.WriteLine(t);
        }
    }
}