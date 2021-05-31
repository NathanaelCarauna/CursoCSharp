using Exceptions.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Withdraw(double amount)
        {
            if(amount > WithdrawLimit)
            {
                throw new WithdrawException("The amount exceeds withdraw limit");
            }
            if(amount > Balance)
            {
                throw new WithdrawException("Not enough balance");
            }
            Balance -= amount;
        }
    }
}
