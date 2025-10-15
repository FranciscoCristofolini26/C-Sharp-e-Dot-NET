using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            int x;
            Console.WriteLine("escreva um valor pra x ai");
            x = int.Parse(Console.ReadLine());


            if (x >= 0)
            {
                Console.WriteLine("POSITIVO");

            }
            else
            {
                Console.WriteLine("Negativo");
            }
        }
    }
}