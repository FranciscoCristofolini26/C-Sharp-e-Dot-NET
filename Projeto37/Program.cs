using System;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo x;
            x = new Retangulo();

            System.Console.WriteLine("Entre a largura e altura do retangulo");
            x.altura = double.Parse(Console.ReadLine());
            x.largura = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Area: " + x.Area());
            System.Console.WriteLine("Perimetro: " + x.Perimetro());
            System.Console.WriteLine("Diagonal: " + x.Diagonal());
        }
    }
}