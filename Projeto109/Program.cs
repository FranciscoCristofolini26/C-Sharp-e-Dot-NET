using System;
using System.Collections.Generic;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("numero pra ver se é perfeito");
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    list.Add(i);
                }
            }
            int soma = list.Sum();

            if (soma == n)
            {
                System.Console.WriteLine("Número é perfeito");
            } else
            {
                System.Console.WriteLine("Não é perfeito");
            }
    
        }
    }
}