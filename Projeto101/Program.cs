using System;
using Course.Extensions;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
            System.Console.WriteLine(dt.ElapsedTime());

            string s1 = "good morning aaaaaaaaaaaaaaaaaa";
            System.Console.WriteLine(s1.Cut(10));
        }
    }
}