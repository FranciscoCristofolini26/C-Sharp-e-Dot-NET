using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Security.Cryptography;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluguel aluguel = new Aluguel();

            System.Console.WriteLine("Quantos alunos ");
            
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string[] Quartos = new string[n];


            string[] alg = new string[n];


            for (int i = 0; i < n; i++)
            {
                
                System.Console.WriteLine($"Aluguel #{i}:");
                System.Console.WriteLine("Nome:");
                aluguel.Nome = Console.ReadLine();
                alg[0] = aluguel.Nome;
                Quartos[i] = alg[0];
                System.Console.WriteLine("Email:");
                aluguel.Email = Console.ReadLine();
                alg[1] = aluguel.Email;
                Quartos[i] = alg[1];
                System.Console.WriteLine("Quarto:");
                aluguel.Quarto = Console.ReadLine();
                alg[2] = aluguel.Quarto;
                Quartos[i] = alg[2];
            }

            foreach (string obj in alg)
            {
                Console.WriteLine(obj);
            }




        }
    }
}