using System;

namespace Course {
    class Program {
        static void Main(string[] args) {
            int n1 = 3 + 4 * 2;

            Console.WriteLine(n1);

            //Dá 11, por causa da precedência das operações. C# interpreta como expressão numérica, então lembrar de usar os parênteses.


            //Agora fazer Bhaskara
            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);


            Console.WriteLine($"delta é {delta}");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(x1);
            Console.WriteLine(x2);

        }
    }
}