using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Exercicio04.Entities
{
    class PhysicalPerson : Taxpayer
    {
        public double HelthExpenses { get; set; }

        public PhysicalPerson()
        {

        }

        public PhysicalPerson(string name, double annualIncome, double helthExpenses) : base(name, annualIncome)
        {
            HelthExpenses = helthExpenses;
        }

        public override double Tax()
        {
            double taxPercentage = 0.15;
            if(AnnualIncome >= 20000)
            {
                taxPercentage = 0.25;
            }
            double tax = AnnualIncome * taxPercentage;

            if(HelthExpenses > 0)
            {
                tax -= HelthExpenses / 2;
            }

            return tax;
        }
    }
}
