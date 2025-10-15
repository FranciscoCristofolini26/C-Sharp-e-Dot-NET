using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ler num divisoes");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Diga dois numeros para dividir");
                string[] x = Console.ReadLine().Split(' ');
                double a = double.Parse(x[0]);
                double b = double.Parse(x[1]);

                if (b > 0)
                {
                    double div = a / b;
                    Console.WriteLine(div);
                } else
                {
                    Console.WriteLine("Divisao impossivel");
                }
            }

        }
    }
}