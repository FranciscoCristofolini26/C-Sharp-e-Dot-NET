using System;
using Course.Entities.Exceptions;

public class ProcessFile
{
    public static void Main()
    {
        try
        {


            System.Console.WriteLine("Room number: ");
            int number = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            System.Console.WriteLine("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if (checkOut <= checkIn)
            {
                throw new DomainException(" Check-out date must be after checkin");

            }
            else
            {
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                System.Console.WriteLine("Reservation: " + reservation);
                System.Console.WriteLine();
                System.Console.WriteLine("Enter data to update the reservation:");
                System.Console.WriteLine("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                System.Console.WriteLine("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);






                reservation.UpdateDates(checkIn, checkOut);
                System.Console.WriteLine("Reservation: " + reservation);

            }
        } catch (DomainExecption e)
        {
            System.Console.WriteLine("Error in reservation: " + e.Message);
        }
    }
}