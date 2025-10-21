using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

            System.Console.WriteLine(t);

            System.Console.WriteLine("Days: " + t.Days);
            System.Console.WriteLine("Hours: " + t.Hours);

            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 10, 5);

            TimeSpan sum = t1.Add(t2);
            TimeSpan dif = t1.Subtract(t2);
            TimeSpan mult = t2.Multiply(2);
            TimeSpan div = t2.Divide(2);

            System.Console.WriteLine(sum);
            System.Console.WriteLine(dif);
            System.Console.WriteLine(mult);
            System.Console.WriteLine(div);
      

        }
    }
}