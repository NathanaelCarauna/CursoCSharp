using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Exercicio04.Entities
{
    class Company : Taxpayer
    {
        public int EmployeeNumbers { get; set; }

        public Company(string name, double annualIncome, int employeeNumbers) : base(name, annualIncome)
        {
            EmployeeNumbers = employeeNumbers;
        }

        public override double Tax()
        {
            double percentageTax = 0.16;
            if(EmployeeNumbers > 10)
            {
                percentageTax = 0.14;
            }
            return AnnualIncome * percentageTax;
        }
    }
}
