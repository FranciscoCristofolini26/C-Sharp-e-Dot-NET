using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("enter rental data");
            System.Console.WriteLine("car model");
            string model = Console.ReadLine();
            System.Console.WriteLine("pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm");
            System.Console.WriteLine("return (dd/MM/yyyy) hh:mm");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm");

            System.Console.WriteLine("enter price per hour");
            double hour = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter price per day");
            double day = double.Parse(Console.ReadLine());

            CarRental carRental = new CarRental(start, finish, new Vehicle(model, start, finish));

            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());


            rentalService.ProcessInvoice(carRental);

            System.Console.WriteLine("Invoice:");
            System.Console.WriteLine(carRental.Invoice);
        }
    }
}