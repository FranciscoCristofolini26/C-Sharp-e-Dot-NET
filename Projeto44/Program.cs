using System;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;
            System.Console.WriteLine("Entre com o numero da conta:");
            int numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.WriteLine("Entre o titular da conta:");
            string titular = Console.ReadLine();
            System.Console.WriteLine("Haverá depósito inicial (s/n)?");
            char sn = char.Parse(Console.ReadLine());
            if (sn == 's' || sn == 'S')
            {
                System.Console.WriteLine("Entre o valor de depósito incial:");
                double depoI = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, titular, depoI);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            System.Console.WriteLine("Dados da Conta:");
            System.Console.WriteLine(conta);

            System.Console.WriteLine("Entre um valor pra depósito:");

            double qntd = double.Parse(Console.ReadLine());
            conta.Deposito(qntd);
            System.Console.WriteLine("Dados da conta atualizados:");
            System.Console.WriteLine(conta);

            System.Console.WriteLine("Entre um valor pra saque:");

            double qnts = double.Parse(Console.ReadLine());
            conta.Saque(qnts);
            System.Console.WriteLine("Dados da conta atualizados:");
            System.Console.WriteLine(conta);
        }
    }
}