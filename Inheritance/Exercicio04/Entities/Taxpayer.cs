using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Exercicio04.Entities
{
    abstract class Taxpayer
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public Taxpayer()
        {

        }

        protected Taxpayer(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Tax();

        public override string ToString()
        {
            return $"{Name}: $ {Tax():F2}";
        }
    }
}
