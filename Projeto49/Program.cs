using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("a");
            int c = int.Parse(Console.ReadLine());

            double[] product = new double[c];

            for (int i = 0; i < c; i++)
            {
                System.Console.WriteLine("Nome");
                Console.ReadLine();
                product[i] = double.Parse(Console.ReadLine());
            }

            double sum = 0;
            for (int i = 0; i < c; i++)
            {
                sum += product[i];
            }

            double avg = sum / c;
            
            System.Console.WriteLine("Preco medio:" + avg.ToString());
        }
    }
}