using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(0, 1, 30);
            TimeSpan t4 = new TimeSpan(0, 1, 30, 22);
            TimeSpan t5 = new TimeSpan(0, 1, 30, 22, 234);
            TimeSpan t6 = TimeSpan.FromDays(1.5);
            TimeSpan t7 = TimeSpan.FromHours(1.5);
            TimeSpan t8 = TimeSpan.FromMinutes(1.5);
            TimeSpan t9 = TimeSpan.FromSeconds(1.5);
            TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t11 = TimeSpan.FromTicks(900000000L);
            System.Console.WriteLine(t1);
            System.Console.WriteLine(t2);
            System.Console.WriteLine(t3);
            System.Console.WriteLine(t4);
            System.Console.WriteLine(t5);
            System.Console.WriteLine(t6);
            System.Console.WriteLine(t7);
            System.Console.WriteLine(t8);
            System.Console.WriteLine(t9);
            System.Console.WriteLine(t10);
            System.Console.WriteLine(t11);
            
        }
    }
}