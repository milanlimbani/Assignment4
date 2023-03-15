using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_1
{
    class CurrAcct : Account
    {

        private double minimumBalance;
        private double serviceCharge;

        public CurrAcct(string customerName, string accountNumber, double balance, double minimumBalance, double serviceCharge)
            : base(customerName, accountNumber, "Current", balance)
        {
            this.minimumBalance = minimumBalance;
            this.serviceCharge = serviceCharge;
        }

        public override void DisplayBalance()
        {
            base.DisplayBalance();
            Console.WriteLine("Minimum balance for this account is {0}.", minimumBalance);
        }

        public override void CheckMinimumBalance(double minimumBalance, double serviceCharge)
        {
            if (balance < minimumBalance)
            {
                balance -= serviceCharge;
                Console.WriteLine("Minimum balance not maintained. Service charge of {0} imposed. New balance is {1}.", serviceCharge, balance);
            }
            else
            {
                Console.WriteLine("Minimum balance maintained.");
            }
        }
    }
}