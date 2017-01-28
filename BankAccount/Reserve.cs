using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Reserve : Account
    {
        //fields
        private double reserveBalance;

        private string accountNum;
        private string accountType;

        //properties
        public double ReserveBalance
        {
            get { return reserveBalance; }
            set { reserveBalance = value; }
        }
        public string AccountType
        {
            get { return accountType; }
            set { accountType = "Reserve"; }
        }

        //constructors
        public Reserve (string accountNum)
        {
            accountNum = this.accountNum;
        }

        //methods
        public double Deposit(double deposit)
        {
            this.ReserveBalance += deposit;
            return this.ReserveBalance;
        }
        public double Withdraw(double withdraw)
        {
            if (this.ReserveBalance - withdraw < 0)
            {
                Console.WriteLine("Insufficient funds. You have $" + this.ReserveBalance + " in your account.\n");
            }
            else
            {
                this.ReserveBalance -= withdraw;
            }
            return this.ReserveBalance;
        }
    }
}
