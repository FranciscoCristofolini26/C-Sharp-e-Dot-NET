using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos Numeros vc vai digitar?");
            int n = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int x = 0; n > x; x++)
            {
                Console.Write("Valor : #{0}: ", x);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;


            }

            Console.WriteLine("Soma = " + soma);
        }
    }
}