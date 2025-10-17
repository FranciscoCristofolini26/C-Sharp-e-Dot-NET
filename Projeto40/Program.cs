using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("Entre o valor do Raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            double volume = Volume(raio);

            System.Console.WriteLine("Circunferencia:" + circ.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Volume:" + volume.ToString("F2", CultureInfo.InvariantCulture));
        }

        
    }
}