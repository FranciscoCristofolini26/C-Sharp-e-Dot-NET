using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            System.Console.WriteLine("Diagonal Principal:");
            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine(mat[i, i] + " ");
            }
            
            if (n == 3)
            {
                int[,] mats = new int[5, 3];
                mats[3, 3] = mat[3, 3];

                

                for (int i = 0; i < n; i++)
                {
                    System.Console.WriteLine(mats[i, i] + " ");
                }
            }
        }
    }
}