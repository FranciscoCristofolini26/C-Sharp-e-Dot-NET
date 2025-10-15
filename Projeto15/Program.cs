using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;

            
            

            Console.WriteLine("Diga um numero inteiro");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("agora outro");
            y = int.Parse(Console.ReadLine());

            if (x % y == 0 || y % x == 0)
            {
                Console.WriteLine("Sao multiplos");

            } else
            {
                Console.WriteLine("nao sao multiplos");
            }
        }
    }
}