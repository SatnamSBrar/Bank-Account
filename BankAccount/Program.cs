using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask client for information
            Console.WriteLine("Welcome to SSB Bank! What is your first name?\n");
            string firstName = Console.ReadLine();

            //forces user to input non-integer name
            //bypasses error if user does not enter a value
            int value = 0;
            while (int.TryParse(firstName, out value) || firstName == "")
            {
                Console.WriteLine("Please enter a valid name");
                string firstName2 = Console.ReadLine();
                firstName = firstName2;
            }

            //capitalizes first letter
            firstName = firstName.First().ToString().ToUpper() + firstName.Substring(1);    

            Console.WriteLine("\nPlease enter your last name:\n");
            string lastName = Console.ReadLine();

            //forces user to input non-integer name
            //bypasses error if user does not enter a value
            value = 0;
            while (int.TryParse(lastName, out value) || lastName == "")
            {
                Console.WriteLine("Please enter a valid name");
                string lastName2 = Console.ReadLine();
                lastName = lastName2;
            }

            //capitalizes first letter
            lastName = lastName.First().ToString().ToUpper() + lastName.Substring(1);       
            
            //ask client to deposit funds into bank accounts
            Console.WriteLine("\nHello, " + firstName + " " + lastName + "! In order to partner with SSB, you will need to make deposits into your new accounts.\n");

            Console.WriteLine("How much would you like to deposit into your Checking Account?\n");
            
                        //stores user input as string
                        string chInput = Console.ReadLine();

                        //bypasses error if user presses enter without entering value
                        //bypasses error if user enters a letter
                        value = -1;
                        while (!int.TryParse(chInput, out value) || chInput == "")
                        {
                            Console.WriteLine("Please enter a valid number");
                            string chInput2 = Console.ReadLine();
                            chInput = chInput2;
                        }

                        //stores user input as integer
                        int chDep = int.Parse(chInput);

            Console.WriteLine("\nHow much would you like to deposit into your Saving Account?\n");

                        //stores user input as string
                        string sInput = Console.ReadLine();

                        //bypasses error if user presses enter without entering value
                        //bypasses error if user enters a letter
                        value = -1;
                        while (!int.TryParse(sInput, out value) || sInput == "")
                        {
                            Console.WriteLine("Please enter a valid number");
                            string sInput2 = Console.ReadLine();
                            sInput = sInput2;
                        }

                        //stores user input as integer
                        int sDep = int.Parse(sInput);

            Console.WriteLine("\nHow much would you like to deposit into your Reserve Account?\n");

                //stores user input as string
                string rInput = Console.ReadLine();

                //bypasses error if user presses enter without entering value
                //bypasses error if user enters a letter
                value = -1;
                while (!int.TryParse(rInput, out value) || rInput == "")
                {
                    Console.WriteLine("Please enter a valid number");
                    string rInput2 = Console.ReadLine();
                    rInput = rInput2;
                }

                //stores user input as integer
                int rDep = int.Parse(rInput);

            //generates account numbers
            Random num = new Random();
            double chAcctNumGen = num.Next(10000);
            double sAcctNumGen = chAcctNumGen + 1;
            double rAcctNumGen = sAcctNumGen + 1;

            string checkingAcctNum = "27274662" + chAcctNumGen.ToString();
            string savingAcctNum = "27274662" + sAcctNumGen.ToString();
            string reserveAcctNum = "27274662" + rAcctNumGen.ToString();

            //instantiates account objects in Checking, Saving, Reserve
            Checking CheckingAccount = new Checking(checkingAcctNum);
            Saving SavingAccount = new Saving(savingAcctNum);
            Reserve ReserveAccount = new Reserve(reserveAcctNum);

            //clears console before dsiplaying menu items
            Console.Clear();

            Console.WriteLine("    ..######...######..########.....########.....###....##....##.##....##");
            Console.WriteLine("    .##....##.##....##.##.....##....##.....##...##.##...###...##.##...##.");
            Console.WriteLine("    .##.......##.......##.....##....##.....##..##...##..####..##.##..##..");
            Console.WriteLine("    ..######...######..########.....########..##.....##.##.##.##.#####...");
            Console.WriteLine("    .......##.......##.##.....##....##.....##.#########.##..####.##..##..");
            Console.WriteLine("    .##....##.##....##.##.....##....##.....##.##.....##.##...###.##...##.");
            Console.WriteLine("    ..######...######..########.....########..##.....##.##....##.##....##");
            Console.WriteLine("\n");

            Console.WriteLine("\t1 - View Client Information");
            Console.WriteLine("\t2 - View Total Balance");
            Console.WriteLine("\t\t3 - Checking");
            Console.WriteLine("\t\t4 - Saving");
            Console.WriteLine("\t\t5 - Reserve");
            Console.WriteLine("\t6 - Deposit Funds");
            Console.WriteLine("\t7 - Withdraw Funds");
            Console.WriteLine("\t8 - Exit\n");

            //stores user input as string
            string userInput = Console.ReadLine();

            //bypasses error if user presses enter without entering value
            while (userInput == "")
            {
                Console.WriteLine("Please enter a valid number");
                string userInput2 = Console.ReadLine();
                userInput = userInput2;
            }

            //bypasses error if user enters a letter
            value = -1;
            while (!int.TryParse(userInput, out value))
            {
                Console.WriteLine("Please enter a valid number");
                string userInput2 = Console.ReadLine();
                userInput = userInput2;
            }

            //stores user input as integer
            int input = int.Parse(userInput);

            //prevents user from entering values out of range
            while (input < 0 || input > 8)
            {
                Console.WriteLine("Please enter a valid number");
                int input2 = int.Parse(Console.ReadLine());
                input = input2;
            }

            //
        }
    }
}
