using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Exercicio01.Entities
{
    class OutSourceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutSourceEmployee(string name, int hours, double valuePerHour, double aditionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = aditionalCharge;
        }
        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
