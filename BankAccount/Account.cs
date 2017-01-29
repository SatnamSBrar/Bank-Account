using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        //fields
        protected string lastName;
        protected string firstName;
        protected string email;
        protected string city;
        protected string state;

        protected int totalBalance;

        //properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string FullName
        {
            get { return lastName + ", " + firstName; }
            set { lastName = value; firstName = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        public int TotalBalance
        {
            get { return totalBalance; }
            set { totalBalance = value; }
        }

        public void DisplayInfo()
        {
            Console.WriteLine("\nClient Information\n");
            Console.WriteLine(this.FullName);
            Console.WriteLine(this.City + ", " + this.State);
            Console.WriteLine(this.Email);
        }
        public void DisplayTotalBalance()
        {
            Console.WriteLine("\nTotal balance across all accounts = $" + this.TotalBalance + "\n");
        }
    }
}
