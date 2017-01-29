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
        private int reserveBalance;

        private string accountNum;

        //properties
        public int ReserveBalance
        {
            get { return reserveBalance; }
            set { reserveBalance = value; }
        }
        public string AccountNum
        {
            get { return accountNum; }
            set { accountNum = value; }
        }

        //constructors
        public Reserve(string accountNum)
        {
            this.AccountNum = accountNum;
        }

        //methods
        public int Deposit(int deposit)
        {
            this.ReserveBalance += deposit;
            return this.ReserveBalance;
        }
        public int Withdraw(int withdraw)
        {
            if (this.ReserveBalance - withdraw < 0)
            {
                Console.WriteLine("\nInsufficient funds. You have $" + this.ReserveBalance + " in your account.\n");
            }
            else
            {
                this.ReserveBalance -= withdraw;
            }
            return this.ReserveBalance;
        }
        public void DisplayBalance()
        {
            Console.WriteLine("\nAccount Number: " + this.accountNum);
            Console.WriteLine("\nYour resernve account balance is $" + this.ReserveBalance + "\n");
        }
    }
}
