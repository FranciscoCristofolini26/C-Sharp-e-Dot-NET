using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diga um valor para ponto x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Diga um valor para ponto y");
            double y = double.Parse(Console.ReadLine());

            if (x == 0 && y == 0 )
            {
                Console.WriteLine("Ponto de Origem");
            } else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            } else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            } else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            } else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            } else if (x == 0 && y != 0)
            {
                Console.WriteLine("Eixo Y");
            } else if (x != 0 && y == 0)
            {
                Console.WriteLine("Eixo X");
            }
        }
    }
}