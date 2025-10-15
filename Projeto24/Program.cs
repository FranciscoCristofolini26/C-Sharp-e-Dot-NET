using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int Alcool = 0;
            int Gasolina = 0;
            int Diesel = 0;
            int x = int.Parse(Console.ReadLine());
            while (x != 4)
            {

                if (x == 1)
                {
                    Alcool++;
                }
                else if (x == 2)
                {
                    Gasolina++;
                }
                else if (x == 3)
                {
                    Diesel++;
                } else if ( x != 1 && x!= 2 && x!=3 && x != 4)
                {
                    System.Console.WriteLine("diga outro valor");
                }


                x = int.Parse(Console.ReadLine());
            }

            System.Console.WriteLine("MUITO OBRIGADO");
            System.Console.WriteLine($"Alcool: {Alcool}");
            System.Console.WriteLine($"Gasolina: {Gasolina}");
            System.Console.WriteLine($"Diesel: {Diesel}");
        }
    }
}