using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {   
            System.Console.WriteLine("Diga quantos valores voce quer escrever");
            int N = int.Parse(Console.ReadLine());
            int Y = 0;
            int W = 0;
            for (int X = 0; X < N; X++)
            {
                Console.WriteLine("diga um valor");
                int i = int.Parse(Console.ReadLine());
                if (i >= 10 && i <= 20)
                {
                    
                    Y++;
                }
                else
                {
                    
                    W++;
                }
            }
            Console.WriteLine($"{Y} in");
            System.Console.WriteLine($"{W} out");
        }
    }
}