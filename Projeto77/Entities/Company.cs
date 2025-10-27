namespace Exercicio.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; } 

        public Company()
        {

        }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double pct;
            if (NumberOfEmployees > 10)
            {
                pct = 0.14;
            }
            else
            {
                pct = 0.16;
            }

            return AnualIncome * pct;
        }
        

    }
}