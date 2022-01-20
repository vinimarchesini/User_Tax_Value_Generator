using System;
using System.Collections.Generic;
using System.Text;

namespace Tax.Entities
{
    class LegalEntity : TaxPayer
    {
        public int EmployeeQuantity { get; set; }

        public LegalEntity()
        {
        }

        public LegalEntity(string name, double anualIncome, int employeequantity) : base(name, anualIncome)
        {
            EmployeeQuantity = employeequantity;
        }
        public override double TaxPayed()
        {
            double taxPayed;
            if (EmployeeQuantity > 10)
            {
                taxPayed = AnualIncome * 0.14;
            } else taxPayed = AnualIncome * 0.16;
            return taxPayed;
        }
    }
}
