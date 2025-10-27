namespace Exercicio.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }
        public Individual()
        {

        }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }



        public override double Tax()
        {
            double pct;
            if (AnualIncome >= 20000)
            {
                pct = 0.25;
            }
            else
            {
                pct = 0.15;
            }
            return AnualIncome * pct - HealthExpenditures * 0.5;
        }
        

    }
}