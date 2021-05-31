using Exceptions.Entities;
using Exceptions.Entities.Exceptions;
using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data:");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double wLimit = double.Parse(Console.ReadLine());

                Account acc = new Account(number, holder, initialBalance, wLimit);

                Console.Write("\nEnter amount for withdraw: ");
                acc.Withdraw(double.Parse(Console.ReadLine()));
                Console.WriteLine("New balance: $" + acc.Balance.ToString("F2"));
            }
            catch (WithdrawException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }


        }
    }
}
