using Interface.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Services
{
    class ContractService
    {
        IPaymentService _paymentService;

        public ContractService(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            for (int i = 1; i <= months; i++)
            {
                double installment = contract.TotalAmount / months;
                installment += _paymentService.Interest(installment, i);
                installment += _paymentService.PaymentFee(installment);

                contract.Installments.Add(new Installment(contract.Date.AddMonths(i), installment));
            }
        }
    }
}
