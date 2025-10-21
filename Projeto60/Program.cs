using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            System.Console.WriteLine(d1);

            DateTime d2 = new DateTime(2018, 11, 25);
            System.Console.WriteLine(d2);

            DateTime d3 = new DateTime(2008, 9, 26, 11, 10, 26);
            System.Console.WriteLine(d3);

            DateTime d4 = DateTime.Now;
            System.Console.WriteLine(d4);

            DateTime d5 = DateTime.Today;
            System.Console.WriteLine(d5);

            DateTime d6 = DateTime.UtcNow;
            System.Console.WriteLine(d6);

            DateTime d7 = new DateTime(2008, 9, 26, 11, 10, 26, 500);
            System.Console.WriteLine(d7);

            DateTime d8 = DateTime.Parse("2008-09-26");
            System.Console.WriteLine(d8);

            DateTime d9 = DateTime.Parse("2008-09-26 13:05:43");
            System.Console.WriteLine(d9);

            DateTime d10 = DateTime.Parse("26/09/2008 13:12:11");
            System.Console.WriteLine(d10);

            DateTime d11 = DateTime.ParseExact("2008-09-26", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            System.Console.WriteLine(d11);

            DateTime d12 = DateTime.ParseExact("26/09/2008 13:12:11", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            

        }
    }
}