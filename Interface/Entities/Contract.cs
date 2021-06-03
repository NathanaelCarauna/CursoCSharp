using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Entities
{
    class Contract
    {
        public int Number { get; private set; }
        public DateTime Date { get; set; }
        public double TotalAmount { get; set; }
        public List<Installment> Installments { get; private set; }

        public Contract(int number, DateTime date, double totalAmount)
        {
            Number = number;
            Date = date;
            TotalAmount = totalAmount;
            Installments = new List<Installment>();
        }
    }
}
