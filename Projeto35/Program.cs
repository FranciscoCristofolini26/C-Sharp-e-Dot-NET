using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario X, Y;

            X = new Funcionario();
            Y = new Funcionario();

            System.Console.WriteLine("Dados do primeiro fucionario:");
            System.Console.WriteLine("Nome:");
            X.nome = Console.ReadLine();
            System.Console.WriteLine("Salário:");
            X.salario = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Dados do segundo fucionario:");
            System.Console.WriteLine("Nome:");
            Y.nome = Console.ReadLine();
            System.Console.WriteLine("Salário:");
            Y.salario = double.Parse(Console.ReadLine());


            double media = (X.salario + Y.salario) / 2;
            System.Console.WriteLine($"Salário médio = {media}");
        }
    }
}