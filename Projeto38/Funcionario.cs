using System.Globalization;

namespace Exercicio
{
    public class Funcionario
    {
        public string nome;
        public double salarioBruto;
        public double imposto;
        public double porcentagem;

        public double SalarioLiquido()
        {
            return salarioBruto - imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            salarioBruto = salarioBruto + (salarioBruto * porcentagem / 100);
        }

        public override string ToString()
        {
            return nome
            + ", R$ "
            + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}