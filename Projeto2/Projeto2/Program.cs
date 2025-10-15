using System;

namespace Course {
    class Program {
        static void Main(string[] args) {
            float x = 4;
            double y = x;

            //double x = 4;
            //float y = x; da erro, pois double tem 8 bytes e float 4
            Console.WriteLine(y);

            double a = 5.1;
            int b = (int)a;
            Console.WriteLine(b);
            //como 5.1 é quebrado, quando converte pra int perde o decimal


            int c = 7;
            int d = 2;

            double resultado = c / d; 
            Console.WriteLine(resultado);

            //da 3 pois acha que o resultado tambem é int

            int e = 9;
            int f = 5;

            double resultado2 = (double)e / f;
            Console.WriteLine(resultado2);
            //aqui ja da quebrado
        }
    }
}