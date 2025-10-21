using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[5, 3];
            System.Console.WriteLine(mat.Length);
            System.Console.WriteLine(mat.Rank);
            System.Console.WriteLine(mat.GetLength(0));
            System.Console.WriteLine(mat.GetLength(1));
        }
    }
}