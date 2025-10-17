using System;
using System.Reflection;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Nome do Aluno: ");
            aluno.nome = Console.ReadLine();
            System.Console.WriteLine("Digite as três notas do aluno:");
            aluno.nota1 = double.Parse(Console.ReadLine());
            aluno.nota2 = double.Parse(Console.ReadLine());
            aluno.nota3 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Nota final = " + aluno.NotaFinal());

            if ( aluno.NotaFinal() >= 60 )
            {
                System.Console.WriteLine("Aprovado.");
            } else
            {
                System.Console.WriteLine("Reprovado.");
                System.Console.WriteLine($"Faltaram {60 - aluno.NotaFinal()} pontos");
            }

        }
    }
}