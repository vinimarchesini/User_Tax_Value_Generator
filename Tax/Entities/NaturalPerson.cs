using System;
using System.Collections.Generic;
using System.Text;

namespace Tax.Entities
{
    class NaturalPerson : TaxPayer
    {
        public double HealthExpense { get; set; }

        public NaturalPerson()
        {
        }

        public NaturalPerson(string name, double anualIncome, double healthExpense) : base(name, anualIncome)
        {
            HealthExpense = healthExpense;
        }

        public override double TaxPayed()
        {
            double taxPayed;
            if (AnualIncome < 20000.00)
            {
                taxPayed = AnualIncome * 0.15 - HealthExpense * 0.50;
            }
            else taxPayed = AnualIncome * 0.25 - HealthExpense * 0.50;
            return taxPayed;
        }
    }
}
