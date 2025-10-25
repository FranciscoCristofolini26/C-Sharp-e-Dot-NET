using System;
using System.Collections;
using Exercicio.Entities;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();
            System.Console.WriteLine("Enter the number of tax payers:");
            int n = int.Parse(Console.ReadLine());
            


            for (int i = 1; i <= n; i++)
            {
                System.Console.WriteLine($"Tax payer #{i} data:");
                System.Console.WriteLine("Individual or company (i/c)?");
                char ch = char.Parse(Console.ReadLine());
                System.Console.WriteLine("Name:");
                string name = Console.ReadLine();
                System.Console.WriteLine("Anual income:");
                double anualIncome = double.Parse(Console.ReadLine());

                if (ch == 'i')
                {
                    System.Console.WriteLine("Health expenditures:");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else if (ch == 'c')
                {
                    System.Console.WriteLine("Number of Employees:");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                }

            }

            
            System.Console.WriteLine();
            System.Console.WriteLine("TAXES PAID");
            foreach (TaxPayer taxPayer in list)
            {
                System.Console.WriteLine(taxPayer);
            }
            System.Console.WriteLine("Total Taxes: $");
            
        }
    }
}