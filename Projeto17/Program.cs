using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double cq = 4;
            double xs = 4.5;
            double xb = 5;
            double ts = 2;
            double r = 1.5;

            

            Console.WriteLine("Diga o codigo que voce quer");
            double ler = double.Parse(Console.ReadLine());
            if (ler == 1)
            {
                double valor = cq;
                Console.WriteLine("Agora diga a quantidade");
                double q = double.Parse(Console.ReadLine());
                double total = valor * q;
                Console.WriteLine($"Total : R$ {total}");
            } else if (ler == 2) {
                double valor = xs;
                Console.WriteLine("Agora diga a quantidade");
                double q = double.Parse(Console.ReadLine());
                double total = valor * q;
                Console.WriteLine($"Total : R$ {total}");
            } else if (ler == 3)
            {
                double valor = xb;
                Console.WriteLine("Agora diga a quantidade");
                double q = double.Parse(Console.ReadLine());
                double total = valor * q;
                Console.WriteLine($"Total : R$ {total}");
            } else if (ler == 4)
            {
                double valor = ts;
                Console.WriteLine("Agora diga a quantidade");
                double q = double.Parse(Console.ReadLine());
                double total = valor * q;
                Console.WriteLine($"Total : R$ {total}");
            } else if (ler == 5)
            {
                double valor = r;
                Console.WriteLine("Agora diga a quantidade");
                double q = double.Parse(Console.ReadLine());
                double total = valor * q;
                Console.WriteLine($"Total : R$ {total}");
            }

        }
    }
}