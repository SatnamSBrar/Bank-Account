using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Saving : Account
    {
        //fields
        private double savingBalance;

        private string accountNum;
        private string accountType;

        //properties
        public double SavingBalance
        {
            get { return savingBalance; }
            set { savingBalance = value; }
        }
        public string AccountType
        {
            get { return accountType; }
            set { accountType = "Saving"; }
        }

        //constructors
        public Saving (string accountNum)
        {
            accountNum = this.accountNum;
        }

        //methods
        public double Deposit(double deposit)
        {
            this.SavingBalance += deposit;
            return this.SavingBalance;
        }
        public double Withdraw(double withdraw)
        {
            if (this.SavingBalance - withdraw < 0)
            {
                Console.WriteLine("Insufficient funds. You have $" + this.SavingBalance + " in your account.\n");
            }
            else
            {
                this.SavingBalance -= withdraw;
            }
            return this.SavingBalance;
        }
    }
}
