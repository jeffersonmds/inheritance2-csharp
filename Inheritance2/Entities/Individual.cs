namespace Inheritance2.Entities
{
    class Individual : Payer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double income, double healthExpenditures) : base(name, income)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double TaxesPaid()
        {
            if (Income > 20000.00)
                return (Income * 0.25) - (HealthExpenditures * 0.5);
            else
                return (Income * 0.15) - (HealthExpenditures * 0.5);
        }
    }
}
