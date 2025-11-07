using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("pt-BR");

            var vendas = new List<Venda>();

            Console.Write("Quantos produtos? ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Número inválido.");
                return;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"[{i+1}/{n}] Digite: VALOR e depois CATEGORIA (ex: 30,50 Eletrônico Celular)");
                string? linha = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(linha))
                {
                    Console.WriteLine("Entrada vazia. Tente novamente.");
                    i--; // repete a iteração
                    continue;
                }

                // divide por espaço; primeira parte = valor, o restante = categoria
                var partes = linha.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (partes.Length < 2)
                {
                    Console.WriteLine("Formato inválido. Ex: 30,50 Eletrônico");
                    i--;
                    continue;
                }

                // tenta converter o valor conforme pt-BR (aceita vírgula)
                if (!double.TryParse(partes[0], NumberStyles.Number, culture, out double valor) || valor < 0)
                {
                    Console.WriteLine("Valor inválido. Use número positivo (ex: 10,00).");
                    i--;
                    continue;
                }

                string categoria = string.Join(' ', partes.Skip(1)).Trim();
                if (string.IsNullOrWhiteSpace(categoria))
                {
                    Console.WriteLine("Categoria inválida.");
                    i--;
                    continue;
                }

                vendas.Add(new Venda(valor, categoria));
            }

            if (vendas.Count == 0)
            {
                Console.WriteLine("Sem vendas para analisar.");
                return;
            }

            // totais e maior venda
            double total = vendas.Sum(v => v.Valor);
            double maiorValor = vendas.Max(v => v.Valor);
            var maiorVenda = vendas.OrderByDescending(v => v.Valor).First();

            // agrupamentos por categoria (normalizando para evitar "Eletrônico" vs "eletronico")
            var porCategoria = vendas
                .GroupBy(v => v.Categoria.Trim())
                .Select(g => new
                {
                    Categoria = g.Key,
                    Total = g.Sum(v => v.Valor),
                    Media = g.Average(v => v.Valor),
                    Quantidade = g.Count()
                })
                .OrderByDescending(x => x.Total)
                .ToList();

            var campea = porCategoria.First(); // maior total

            // Top 3 vendas
            var top3 = vendas
                .OrderByDescending(v => v.Valor)
                .Take(3)
                .ToList();

            // ---- Saídas ----
            Console.WriteLine();
            Console.WriteLine($"Total vendido: {total.ToString("N2", culture)}");
            Console.WriteLine($"Maior venda: {maiorValor.ToString("N2", culture)} (Categoria: {maiorVenda.Categoria})");

            Console.WriteLine();
            Console.WriteLine($"Categoria campeã: {campea.Categoria} (Total: {campea.Total.ToString("N2", culture)})");

            Console.WriteLine();
            Console.WriteLine("Totais/Médias por categoria:");
            foreach (var c in porCategoria)
            {
                Console.WriteLine($"  - {c.Categoria}: Total {c.Total.ToString("N2", culture)} | Média {c.Media.ToString("N2", culture)} | Qtde {c.Quantidade}");
            }

            Console.WriteLine();
            Console.WriteLine("Top 3 vendas:");
            foreach (var v in top3)
            {
                Console.WriteLine($"  - {v.Valor.ToString("N2", culture)} ({v.Categoria})");
            }
        }
    }


}
