using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Services
{
    interface IPaymentService
    {
        public double Interest(double amount, int months);
        public double PaymentFee(double amount);
    }
}
