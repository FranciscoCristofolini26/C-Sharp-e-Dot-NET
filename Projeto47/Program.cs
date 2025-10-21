using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10;

            double a = x ?? 5;
            double b = y ?? 5;

            System.Console.WriteLine(a);
            System.Console.WriteLine(b);
        }
    }
}