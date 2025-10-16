using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            System.Console.WriteLine("Nome");
            func.nome = Console.ReadLine();
            System.Console.WriteLine("Salário Bruto:");
            func.salarioBruto = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Imposto");
            func.imposto = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Funcionário: " + func.nome + ", $" + func.SalarioLiquido());

            System.Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double porcent = double.Parse(Console.ReadLine());
            func.AumentarSalario(porcent);
            System.Console.WriteLine("Dados atualizados: " + func.nome + ", $ " + func.SalarioLiquido());
        }
    }
}