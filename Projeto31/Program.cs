using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Diga um valor pra N que te retornarei todos os seus divisores");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if (N % i == 0)
                {
                    int div = N / i;
                    System.Console.WriteLine(div);
                }
            }
        }
    }
}