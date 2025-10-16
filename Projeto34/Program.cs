using System;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa A, B;


            A = new Pessoa();
            B = new Pessoa();

            System.Console.WriteLine("Insira seu nome");
            A.nome = Console.ReadLine();
            System.Console.WriteLine("Insira sua idade");
            A.idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Bota o nome de quem tu quiser ai");
            B.nome = Console.ReadLine();
            System.Console.WriteLine("agr qualquer numero mesmo");
            B.idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



            if (A.idade > B.idade)
            {
                System.Console.WriteLine($"Pessoa mais velha: {A.nome}");
            } else if (B.idade > A.idade)
            {
                System.Console.WriteLine($"Pessoa mais velha: {B.nome}");
            } else
            { 
                System.Console.WriteLine("caraca, mesma idade, parabens!");
            }
        }
    }
}