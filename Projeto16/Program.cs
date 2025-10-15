using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("me diga o horario de inicio");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("me diga o horario de termino");
            int y = int.Parse(Console.ReadLine());

            if (x >= y)
            {
                int z = y + 24;
                int t = z - x;
                Console.WriteLine($"O jogo durou {t} hora(s)");
            } else
            {
                int t = y - x;
                Console.WriteLine($"O jogo durou {t} hora(s)");
            }
        }
    }
}