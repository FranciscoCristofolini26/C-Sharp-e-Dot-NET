using System;
using System.IO;
using Exercicio.Entities;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Students> set = new HashSet<Students>();

            System.Console.Write("How many students for course A?");
            int a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                System.Console.WriteLine($"Codigo do aluno {i}:");
                int code = int.Parse(Console.ReadLine());
                set.Add(new Students(code));
            }
            
            System.Console.Write("How many students for course B?");
            int b = int.Parse(Console.ReadLine());

            for (int i = 1; i <= b; i++)
            {
                System.Console.WriteLine($"Codigo do aluno {i}:");
                int code = int.Parse(Console.ReadLine());
                set.Add(new Students(code));
            }

            System.Console.Write("How many students for course C?");
            int c = int.Parse(Console.ReadLine());

            for (int i = 1; i <= c; i++)
            {
                System.Console.WriteLine($"Codigo do aluno {i}:");
                int code = int.Parse(Console.ReadLine());
                set.Add(new Students(code));
            }
            
            System.Console.WriteLine("Total students:" + set.Count);
        }
    }
}