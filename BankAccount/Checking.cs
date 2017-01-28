using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Checking : Account
    {
        //fields
        private double checkingBalance;

        private string accountNum;
        private string accountType;

        //properties
        public double CheckingBalance
        {
            get { return checkingBalance; }
            set { checkingBalance = value; }
        }
        public string AccountType
        {
            get { return accountType; }
            set { accountType = "Checking"; }
        }

        //constructors
        public Checking (string accountNum)
        {
            accountNum = this.accountNum;
        }

        //methods
        public double Deposit (double deposit)
        {
            this.CheckingBalance += deposit;
            return this.CheckingBalance;
        }
        public double Withdraw(double withdraw)
        {
            if (this.CheckingBalance - withdraw < 0)
            {
                Console.WriteLine("Insufficient funds. You have $" + this.CheckingBalance + " in your account.\n");
            }
            else
            {
                this.CheckingBalance -= withdraw;
            }
            return this.CheckingBalance;
        }
    }
}
