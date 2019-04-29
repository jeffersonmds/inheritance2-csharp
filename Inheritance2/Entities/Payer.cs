namespace Inheritance2.Entities
{
    abstract class Payer
    {
        public string Name { get; set; }
        public double Income { get; set; }

        protected Payer(string name, double income)
        {
            Name = name;
            Income = income;
        }

        public abstract double TaxesPaid();
    }
}
