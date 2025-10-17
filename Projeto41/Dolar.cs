using System;
using System.Runtime.Serialization;

namespace Exercicio
{
    public class Dolar
    {
        public static double Iof = 6.0;
        

        public static double ValorPagar(double cotacao, double compra)
        {
            double total = compra * cotacao;
            return total + total * Iof / 100;
        }
        

    }
}