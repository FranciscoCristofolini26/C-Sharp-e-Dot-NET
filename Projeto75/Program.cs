using System;
using System.Globalization;
using Exercicio.Entities;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            System.Console.WriteLine("Enter the number of products:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                System.Console.WriteLine($"Product #{i} data:");
                System.Console.WriteLine("Common, used or imported (c/u/i)?");
                char ch = char.Parse(Console.ReadLine());
                System.Console.WriteLine("Name:");
                string name = Console.ReadLine();
                System.Console.WriteLine("Price:");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Product product = new Product();
                if (ch == 'i' || ch == 'i')
                {

                    System.Console.WriteLine("Customs fee:");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));

                }
                else if (ch == 'u' || ch == 'U')
                {
                    System.Console.WriteLine("Manufacture date ( DD/MM/YYYY):");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactureDate));
                }
                else if (ch == 'c' || ch == 'C')
                {
                    list.Add(new Product(name, price));
                }
                else
                {
                    System.Console.WriteLine("Invalid char");
                }
            }
            System.Console.WriteLine();
            System.Console.WriteLine("PRICE TAGS");
            foreach (Product prod in list)
            {
                System.Console.WriteLine(prod.PriceTag());
            }
        }
    }
}