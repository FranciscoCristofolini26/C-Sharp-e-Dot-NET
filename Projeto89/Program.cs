using System;
using System.Globalization;
using System.IO;
using Exercicio.Entities;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Inicio aq, bota o caminho do csv");
            string path = System.Console.ReadLine();

            List<Linhas> lines = new List<Linhas>();

            
            try
            {
                
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] itens = line.Split(",");
                        string name = itens[0];
                        double price = double.Parse(itens[1], CultureInfo.InvariantCulture);
                        int number = int.Parse(itens[2], CultureInfo.InvariantCulture);
                        lines.Add(new Linhas(name, price, number));

                        double finalValue = price * number;
                        System.Console.WriteLine(finalValue);
                    }
                }
                    
                
            }
            
            catch (IOException e)
            {
                System.Console.WriteLine("an error ocurred");
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
