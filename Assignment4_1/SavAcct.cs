using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_1
{
    class SavAcct : Account
    {
        private double interestRate;

        public SavAcct(string customerName, string accountNumber, double balance, double interestRate)
            : base(customerName, accountNumber, "Savings", balance)
        {
            this.interestRate = interestRate;
        }

        public override void ComputeInterest()
        {
            double interest = balance * interestRate / 100;
            balance += interest;
            Console.WriteLine("Interest of {0} added. New balance is {1}.", interest, balance);
        }
    }
}