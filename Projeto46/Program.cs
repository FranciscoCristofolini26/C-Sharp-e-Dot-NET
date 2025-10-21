using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10.0;

            System.Console.WriteLine(x.GetValueOrDefault());
            System.Console.WriteLine(x.GetValueOrDefault());

            System.Console.WriteLine(x.HasValue);
            System.Console.WriteLine(y.HasValue);
            if (x.HasValue)
            {
                System.Console.WriteLine(x.Value);
            }
            
            if (y.HasValue)
            {
                System.Console.WriteLine(y.Value);
            }
            
        }
    }
}