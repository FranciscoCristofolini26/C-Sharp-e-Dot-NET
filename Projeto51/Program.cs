using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(2, 4, 3);

            System.Console.WriteLine(s1);
            System.Console.WriteLine(s2);*/
            /*int a = 10;
            Calculator.Triple(ref a);
            System.Console.WriteLine(a);*/

            int a = 10;
            int triple;
            Calculator.Triple(a, out triple);
            System.Console.WriteLine(triple);


        }
    }
}

//Considerações: A variavel que o ref pega de parametro tem q ter sido iniciada antes
//Usando in e out não
//mas nao usar