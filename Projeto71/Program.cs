using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Cria lista de listas (matriz)
        List<List<int>> mat = new List<List<int>>();

        // Leitura da matriz 3x3
        for (int i = 0; i < 3; i++)
        {
            string[] linha = Console.ReadLine().Split(' ');
            List<int> linhaAtual = new List<int>();
            foreach (string val in linha)
                linhaAtual.Add(int.Parse(val));
            mat.Add(linhaAtual);
        }

        // Diagonais positivas e negativas
        int somaPos = 0;
        int somaNeg = 0;

        // Para diagonais principais (positivas)
        for (int i = 0; i < 3; i++)
        {
            int prodPos = 1;
            int prodNeg = 1;

            for (int j = 0; j < 3; j++)
            {
                prodPos *= mat[j][(i + j) % 3];        // diagonal descendo
                prodNeg *= mat[j][(i + 3 - j) % 3];    // diagonal subindo
            }

            somaPos += prodPos;
            somaNeg += prodNeg;
        }

        int determinante = somaPos - somaNeg;

        Console.WriteLine($"Determinante (Lei de Sarrus): {determinante}");
    }
}
