using System;
using System.Globalization;
using System.Net.Http.Headers;
using Exercicio.Entities;
using Exercicio.Entities.Enums;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter client data:");
            System.Console.WriteLine("Name:");
            string clientName = Console.ReadLine();
            System.Console.WriteLine("Email:");
            string clientEmail = Console.ReadLine();
            System.Console.WriteLine("Birth date (DD/MM/YYYY): ");
            string clientBirth = Console.ReadLine();

            Client client = new Client(clientName, clientEmail, clientBirth);
           
            System.Console.WriteLine("");
            System.Console.WriteLine("Enter order data:");
            System.Console.WriteLine("Status:");
            string orderStatus = Console.ReadLine();
            System.Console.WriteLine("How many items to this order?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine($"Enter #{i} item data:");
                System.Console.WriteLine("Product name:");
                string pName = Console.ReadLine();
                System.Console.WriteLine("Product price:");
                double pPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                System.Console.WriteLine("Quantity");
                Product product = new Product(pName, price);

                int pQuantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(pQuantity, pPrice, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);

        }
    }
}