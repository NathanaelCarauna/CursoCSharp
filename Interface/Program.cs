using Interface.Entities;
using Interface.Services;
using System;
using System.Globalization;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: R$ ");
            double value = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, value);
            IPaymentService paymentService = new PaymentService();
            ContractService contractService = new ContractService(paymentService);
            contractService.ProcessContract(contract, months);

            Console.WriteLine("INSTALLMENTS:");
            foreach(var installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }

        }
    }
}
