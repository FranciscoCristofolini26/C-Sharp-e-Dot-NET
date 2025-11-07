namespace Exercicio
{
    class Venda
    {
        public double Valor { get; set; }
        public string Categoria { get; set; }

    
        public Venda(double valor, string categoria)
        {
            Categoria = categoria;
            Valor = valor;
        }
        public override string ToString()
        {
            return $"{Valor} - {Categoria}";
        }
    }
}