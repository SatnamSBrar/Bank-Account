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
        private int savingBalance;

        private string accountNum;

        //properties
        public int SavingBalance
        {
            get { return savingBalance; }
            set { savingBalance = value; }
        }
        public string AccountNum
        {
            get { return accountNum; }
            set { accountNum = value; }
        }

        //constructors
        public Saving(string accountNum)
        {
            this.AccountNum = accountNum;
        }

        //methods
        public int Deposit(int deposit)
        {
            this.SavingBalance += deposit;
            return this.SavingBalance;
        }
        public int Withdraw(int withdraw)
        {
            if (this.SavingBalance - withdraw < 0)
            {
                Console.WriteLine("\nInsufficient funds. You have $" + this.SavingBalance + " in your account.\n");
            }
            else
            {
                this.SavingBalance -= withdraw;
            }
            return this.SavingBalance;
        }
        public void DisplayBalance()
        {
            Console.WriteLine("\nAccount Number: " + this.accountNum);
            Console.WriteLine("\nYour saving account balance is $" + this.SavingBalance + "\n");
        }
    }
}
