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
        private int checkingBalance;

        private string accountNum;

        //properties
        public int CheckingBalance
        {
            get { return checkingBalance; }
            set { checkingBalance = value; }
        }
        public string AccountNum
        {
            get { return accountNum; }
            set { accountNum = value; }
        }
        
        //constructors
        public Checking (string accountNum)
        {
            this.AccountNum = accountNum;
        }

        //methods
        public int Deposit (int deposit)
        {
            this.CheckingBalance += deposit;
            return this.CheckingBalance;
        }
        public int Withdraw(int withdraw)
        {
            if (this.CheckingBalance - withdraw < 0)
            {
                Console.WriteLine("\nInsufficient funds. You have $" + this.CheckingBalance + " in your account.\n");
            }
            else
            {
                this.CheckingBalance -= withdraw;
            }
            return this.CheckingBalance;
        }
        public void DisplayBalance()
        {
            Console.WriteLine("\nAccount Number: " + this.accountNum);
            Console.WriteLine("\nYour checking account balance is $" + this.CheckingBalance + "\n");
        }
    }
}
