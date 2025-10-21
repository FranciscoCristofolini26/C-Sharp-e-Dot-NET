using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            System.Console.WriteLine(d);
            System.Console.WriteLine("1) Date: " + d.Date);
            System.Console.WriteLine("2) Day: " + d.Day);
            System.Console.WriteLine("3) DayOfWeek " + d.DayOfWeek);
            System.Console.WriteLine("4) DayOfYear " + d.DayOfYear);
            System.Console.WriteLine("5) Hour: " + d.Hour);
            System.Console.WriteLine("6) Kind: " + d.Kind);
            System.Console.WriteLine("7) Millisecond " + d.Millisecond);
            System.Console.WriteLine("8) Minute " + d.Minute);
            System.Console.WriteLine("9) Month " + d.Month);
            System.Console.WriteLine("10) Second: " + d.Second);
            System.Console.WriteLine("11) Ticks: " + d.Ticks);
            System.Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            System.Console.WriteLine("13) Year: " + d.Year);
            
        }
    }
}