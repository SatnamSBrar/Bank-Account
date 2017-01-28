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
        protected string lastName;
        protected string firstName;

        protected double totalBalance;

        //properties
        public string FullName
        {
            get { return lastName + ", " + firstName; }
            set { lastName = value;  firstName = value; }
        }
        public double TotalBalance
        {
            get { return totalBalance; }
            set { totalBalance = value; }
        }
    }
}
