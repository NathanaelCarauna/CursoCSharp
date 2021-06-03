using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Services
{
    class PaymentService : IPaymentService
    {
        public double Interest(double amount, int months)
        {
            double interest = amount * 0.01 * months;
            return interest;
        }

        public double PaymentFee(double amount)
        {
            double fee = amount * 0.02;
            return fee;
        }
    }
}
