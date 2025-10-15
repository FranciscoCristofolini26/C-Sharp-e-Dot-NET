using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Diga um valor inteiro de 1 até 1000");
            int x = int.Parse(Console.ReadLine());

            if (x >= 1 && x <= 1000)
            {
                for (int i = 1; x >= i; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                   
                }
            }
        }
    }
}