using System;
using System.Globalization;

namespace exsoma {
    class Program {
        static void Main(string[] args) {
            int n1, n2, n3;

            Console.WriteLine("Bom dia! Neste programa, será realizado uma soma entre dois valores.");
            Console.WriteLine("Por favor insira um valor inteiro.");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Agora insira outro valor.");
            n2 = int.Parse(Console.ReadLine());

            n3 = n1 + n2;
            Console.WriteLine($"A soma dos dois valores é {n3}");
        }
    }
}