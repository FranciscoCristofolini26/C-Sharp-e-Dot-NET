using System;

namespace Exercicio.Entities
{
    class Linhas
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Number { get; set; }

        public Linhas()
        {

        }

        public Linhas(string name, double price, int number)
        {
            Name = name;
            Price = price;
            Number = number;
        }

        public double FinalValue()
        {
            return Price * Number;
        } 
    }
}