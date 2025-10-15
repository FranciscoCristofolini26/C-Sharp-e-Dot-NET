using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Me diga um valor doubleeiro Positivo N");
            double N = double.Parse(Console.ReadLine());

            for (double i = 1; i <= N; i++)
            {
                double q = Math.Pow(i, 2);
                double c = Math.Pow(i, 3);
                Console.WriteLine($"{i} {q} {c}");
                
            }
        }
    }
}