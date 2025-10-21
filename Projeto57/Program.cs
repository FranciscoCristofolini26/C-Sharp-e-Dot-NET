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


            System.Console.WriteLine("Determinante da matriz");

            if (n == 2)
            {

                int dP = mat[0, 0] * mat[1, 1];
                int dS = mat[0, 1] * mat[1, 0];
                int det = dP - dS;
                System.Console.WriteLine(det);
            } else if (n == 3)
            {
                int dP1 = mat[0, 0] * mat[1, 1] * mat[2, 2];
                int dP2 = mat[1, 0] * mat[2, 1] * mat[0, 2];
                int dP3 = mat[2, 0] * mat[0, 1] * mat[1, 2];
                int dS1 = mat[0, 2] * mat[1, 1] * mat[2, 0];
                int dS2 = mat[1, 2] * mat[2, 1] * mat[0, 0];
                int dS3 = mat[2, 2] * mat[0, 1] * mat[1, 0];
                System.Console.WriteLine(dP1 + dP2 + dP3 - (dS1 + dS2 + dS3));
            }
            
            
            

    
        }
    }
}