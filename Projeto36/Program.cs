using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();


            System.Console.WriteLine("Entre os dados do produto:");
            System.Console.WriteLine("Nome:");
            p.Nome = Console.ReadLine();
            System.Console.WriteLine("Preço:");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.WriteLine("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            System.Console.WriteLine($"Dados do produto: {p}");
            System.Console.WriteLine();
            System.Console.WriteLine("Digite o num de produtos a serem adicionados");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            System.Console.WriteLine("Dados atualizados: " + p);
            
            System.Console.WriteLine();
            System.Console.WriteLine("Digite o num de produtos a serem removidos");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            System.Console.WriteLine("Dados atualizados: " + p);
        }
    }
}