namespace Inheritance2.Entities
{
    class Company : Payer
    {
        public int Employees { get; set; }

        public Company(string name, double income, int employees) : base(name, income)
        {
            Employees = employees;
        }

        public override double TaxesPaid()
        {
            if (Employees > 10)
                return Income * 0.14;
            else
                return Income * 0.16;
        }
    }
}
