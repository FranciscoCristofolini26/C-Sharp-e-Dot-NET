using System;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Qual é a cotação do dólar?");
            double cotacao = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Quantos dólares você vai comprar?");
            double compra = double.Parse(Console.ReadLine());

            double valorPagar = Dolar.ValorPagar(cotacao, compra);

            System.Console.WriteLine("Valor a ser pago em reais = " + valorPagar.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}