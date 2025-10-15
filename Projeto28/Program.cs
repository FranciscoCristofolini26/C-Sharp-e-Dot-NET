using System;
using System.Security.Cryptography.X509Certificates;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("quantos cases queres testar?");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Diga suas notas");
                string[] x = Console.ReadLine().Split(' ');
                double a = double.Parse(x[0]) * 2;
                double b = double.Parse(x[1]) * 3;
                double c = double.Parse(x[2]) * 5;


                System.Console.WriteLine(a);
                System.Console.WriteLine(b);
                System.Console.WriteLine(c);

                double media = (a + b + c) / 10;
                Console.WriteLine(media);
                
            
            }
            
        }
    }
}