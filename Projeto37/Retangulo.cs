using System;


namespace Exercicio
{
    public class Retangulo
    {
        public double largura;
        public double altura;

        public double Area()
        {
            return altura * largura / 2;
        }

        public double Perimetro()
        {
            return (altura * 2) + (largura * 2);
        }

        public double Diagonal()
        {
            double hipQ = Math.Pow(altura, 2) + Math.Pow(largura, 2);
            return Math.Sqrt(hipQ);
        }
    }
}
