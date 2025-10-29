using System;
using Exercicio.Entities;
using System.Globalization;
using System.Diagnostics.Contracts;
using Exercicio.Services;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter contract data:");
            System.Console.WriteLine("Number:");
            int contractNumber = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Date (dd/MM/yyyy):");
            DateTime contractDate = DateTime.Parse(Console.ReadLine());
            System.Console.WriteLine("Contract value:");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.WriteLine("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract myContract = new Contract(contractNumber, contractDate, contractValue);

            ContractService contractService = new ContractService(new PayPalService());
            contractService.ProcessContract(myContract, months);

            System.Console.WriteLine("Installments: ");
            foreach (Installment installment in myContract.Installments)
            {
                System.Console.WriteLine(installment);
            }

        }
    }
}