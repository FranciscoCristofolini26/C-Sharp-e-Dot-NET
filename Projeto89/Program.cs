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

            string path = @"csv\pasta.csv";
            string targetPath = @"csv\summary.csv";

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




                        Linhas linhas = new Linhas(name, price, number);
                        using (StreamWriter sw = File.AppendText(targetPath))
                        {
                            
                            sw.WriteLine(linhas.Name + "," + linhas.FinalValue().ToString("F2", CultureInfo.InvariantCulture));
                            
                        }
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
