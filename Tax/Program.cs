using System;
using System.Collections.Generic;
using System.Globalization;
using Tax.Entities;

namespace Tax
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> taxPayers = new List<TaxPayer>();
            Console.Write("Enter the number of taxpayers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax Payer #{i} data:");
                Console.Write("Individual or Company(i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == char.Parse("i"))
                {
                    Console.Write("Health Expenditures: ");
                    double healthExpense = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxPayers.Add(new NaturalPerson(name, anualIncome, healthExpense));
                } else if (ch == char.Parse("c"))
                {
                    Console.Write("Number of Employees: ");
                    int employeeQuantity = int.Parse(Console.ReadLine());
                    taxPayers.Add(new LegalEntity(name, anualIncome, employeeQuantity));
                }
            }

            Console.WriteLine("TAXES PAID:");
            double totalTaxes = 0;
            foreach(TaxPayer tp in taxPayers)
            {
                Console.WriteLine($"{tp.Name}: $ {tp.TaxPayed().ToString("F2", CultureInfo.InvariantCulture)}");
                totalTaxes += tp.TaxPayed();
            }
            Console.WriteLine(totalTaxes.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
