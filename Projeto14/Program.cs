using System;

namespace Course
{
    class Program
    {

        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("escreva um valor pra dizer se é par ou impar");
            x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("PAR");
            } else
            {
                System.Console.WriteLine("Impar");
            }
            
    
        

        }
    }
}

