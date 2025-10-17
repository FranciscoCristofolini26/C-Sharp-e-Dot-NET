using System;
using System.Globalization;

namespace calc {
    class Program {
        static void Main(string[] args) {
            float A, B, C;
            double pi = 3.14159;
            Console.WriteLine("Insira o valor de A");
            A = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor de B");
            B = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor de C");
            C = float.Parse(Console.ReadLine());

            float ATR = A * C / 2;
            double AC = Math.Pow(C, 2.0) * pi;
            double AT = (A + B) * C / 2;


            Console.WriteLine($"A área do triângulo retângulo de base A e altura C é {ATR}");
            Console.WriteLine($"A área do círculo de raio C é {AC}");
            Console.WriteLine($"A área do trapézio de bases A e B com altura C é {AT}");


        }
    }
}