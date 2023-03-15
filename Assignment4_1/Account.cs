using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_1
{
    class Account
    {
        protected string customerName;
        protected string accountNumber;
        protected string accountType;
        protected double balance;

        public Account(string customerName, string accountNumber, string accountType, double balance)
        {
            this.customerName = customerName;
            this.accountNumber = accountNumber;
            this.accountType = accountType;
            this.balance = balance;
        }

        public virtual void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine("Deposit of {0} successful. New balance is {1}.", amount, balance);
        }

        public virtual void DisplayBalance()
        {
            Console.WriteLine("Account balance is {0}.", balance);
        }

        public virtual void ComputeInterest()
        {
            Console.WriteLine("No interest for this account.");
        }

        public virtual void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("Withdrawal of {0} successful. New balance is {1}.", amount, balance);
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }

        public virtual void CheckMinimumBalance(double minimumBalance, double serviceCharge)
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
