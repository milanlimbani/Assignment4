using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("enter your bank account number:");
            string accoutno = Console.ReadLine();

            Console.WriteLine("enter your starting balance:");
            int balance = int.Parse(Console.ReadLine());

            Console.WriteLine("which type account you want open:(saving or current)");
            string account = Console.ReadLine();
            if (account == "saving")
            {
                int interstrate = 3;
                SavAcct sav = new SavAcct(name, accoutno, balance, interstrate);
                int choice;
                do
                {
                    Console.WriteLine("\n1. Display balance");
                    Console.WriteLine("2. balance deposit");
                    Console.WriteLine("3. balance withdraw");
                    Console.WriteLine("4. ComputeInterest");

                    Console.WriteLine("5. Exit");
                    Console.Write("Enter your choice: ");

                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            sav.DisplayBalance();
                            break;
                        case 2:
                            Console.WriteLine("how many you deposit");
                            double amount = double.Parse(Console.ReadLine());
                            sav.Deposit(amount);
                            break;
                        case 3:
                            Console.WriteLine("how many you withdraw");
                            double wamount = double.Parse(Console.ReadLine());
                            sav.Withdraw(wamount);
                            break;
                        case 4:
                            sav.ComputeInterest();
                            break;

                        case 5:
                            Console.WriteLine("Goodbye!");
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                } while (choice != 5);
            }
            else if (account == "current")
            {
                double minbalance = 500;
                double servicecharge = 50;
                CurrAcct curr = new CurrAcct(name, account, balance, minbalance, servicecharge);

                int choice;
                do
                {
                    Console.WriteLine("\n1. Display balance");
                    Console.WriteLine("2. balance deposit");
                    Console.WriteLine("3. balance withdraw");
                    Console.WriteLine("4. ComputeInterest");
                    Console.WriteLine("5. check mininum balance");

                    Console.WriteLine("6. Exit");
                    Console.Write("Enter your choice: ");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            curr.DisplayBalance();
                            break;
                        case 2:
                            Console.WriteLine("how many you deposit");
                            double amount = double.Parse(Console.ReadLine());
                            curr.Deposit(amount);
                            break;
                        case 3:
                            Console.WriteLine("how many you withdraw");
                            double wamount = double.Parse(Console.ReadLine());
                            curr.Withdraw(wamount);
                            break;
                        case 4:
                            curr.ComputeInterest();
                            break;
                        case 5:
                            curr.CheckMinimumBalance(minbalance, servicecharge);
                            break;

                        case 6:
                            Console.WriteLine("Goodbye!");
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                } while (choice != 6);
            }
            Console.ReadKey();
        }






    
    }
}

