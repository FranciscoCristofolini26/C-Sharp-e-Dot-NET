using System;
using Exercicio.Entities;
using Exercicio.Entities.Exceptions;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter account data:");
            System.Console.WriteLine("Number:");
            int number = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Holder:");
            string holder = Console.ReadLine();
            System.Console.WriteLine("Initial Balance:");
            double balance = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Withdraw limit:");
            double withdrawLimit = double.Parse(Console.ReadLine());
            System.Console.WriteLine();
            System.Console.WriteLine("Enter amount for withdraw:");
            double amount = double.Parse(Console.ReadLine());
            Account acc = new Account(number, holder, balance, withdrawLimit);


            try
            {
                acc.Withdraw(amount);
                Console.WriteLine("New balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }

        }
    }
}