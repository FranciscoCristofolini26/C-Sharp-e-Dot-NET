using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua senha:");
            string key = Console.ReadLine();

            while (key.ToString() != "2002")
            {

                Console.WriteLine("Senha Inválida");
                Console.WriteLine("Digite novamente");
                key = Console.ReadLine();

                if (key.ToString() == "2002")
                {
                    Console.WriteLine("Acesso Permitido");
                    break;
                }
                
            } 
        }
    }
}