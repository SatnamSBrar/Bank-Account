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
                            Console.WriteLine("\nPlease enter a valid name\n");
                            string firstName2 = Console.ReadLine();
                            firstName = firstName2;
                        }

            //capitalizes first letter
            firstName.ToLower();
            firstName = firstName.First().ToString().ToUpper() + firstName.Substring(1);    

            Console.WriteLine("\nPlease enter your last name:\n");
            string lastName = Console.ReadLine();

                        //forces user to input non-integer name
                        //bypasses error if user does not enter a value
                        value = 0;
                        while (int.TryParse(lastName, out value) || lastName == "")
                        {
                            Console.WriteLine("\nPlease enter a valid name\n");
                            string lastName2 = Console.ReadLine();
                            lastName = lastName2;
                        }

            //capitalizes first letter
            lastName.ToLower();
            lastName = lastName.First().ToString().ToUpper() + lastName.Substring(1);

            Console.WriteLine("\nWhat state do you live in?\n");
            string state = Console.ReadLine();

                        //forces user to input non-integer name
                        //bypasses error if user does not enter a value
                        value = 0;
                        while (int.TryParse(state, out value) || state == "")
                        {
                            Console.WriteLine("\nPlease enter a valid state\n");
                            string state2 = Console.ReadLine();
                            state = state2;
                        }

            //capitalizes state name
            state = state.ToUpper();

            Console.WriteLine("\nWhat city do you live in?\n");
            string city = Console.ReadLine();

                        //forces user to input non-integer name
                        //bypasses error if user does not enter a value
                        value = 0;
                        while (int.TryParse(city, out value) || city == "")
                        {
                            Console.WriteLine("\nPlease enter a valid city\n");
                            string city2 = Console.ReadLine();
                            city = city2;
                        }

            //capitalizes first letter
            city.ToLower();
            city = city.First().ToString().ToUpper() + city.Substring(1);

            Console.WriteLine("\nPlease enter your email address:\n");
            string email = Console.ReadLine();

                        //bypasses error if user does not enter a value
                        //forces user to enter ".com" and "@"
                        while (email == "" || email.Contains("@") == false || email.Contains(".com") == false)
                        {
                            Console.WriteLine("\nPlease enter a valid email\n");
                            string email2 = Console.ReadLine();
                            email = email2;
                        }
            
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
                            Console.WriteLine("\nPlease enter a valid number\n");
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
                            Console.WriteLine("\nPlease enter a valid number\n");
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
                    Console.WriteLine("\nPlease enter a valid number\n");
                    string rInput2 = Console.ReadLine();
                    rInput = rInput2;
                }

                //stores user input as integer
                int rDep = int.Parse(rInput);

            //generates account numbers
            Random num = new Random();
            int chAcctNumGen = num.Next(10000);
            int sAcctNumGen = chAcctNumGen + 1;
            int rAcctNumGen = sAcctNumGen + 1;

            string checkingAcctNum = "27274662" + chAcctNumGen.ToString();
            string savingAcctNum = "27274662" + sAcctNumGen.ToString();
            string reserveAcctNum = "27274662" + rAcctNumGen.ToString();

            //instantiates account objects in Checking, Saving, Reserve
            Checking CheckingAccount = new Checking(checkingAcctNum)
            {
                AccountNum = checkingAcctNum
            };
            Saving SavingAccount = new Saving(savingAcctNum)
            {
                AccountNum = savingAcctNum
            };
            Reserve ReserveAccount = new Reserve(reserveAcctNum)
            {
                AccountNum = reserveAcctNum
            };

            //inputs balance into account objects
            CheckingAccount.CheckingBalance = chDep;
            SavingAccount.SavingBalance = sDep;
            ReserveAccount.ReserveBalance = rDep;
            
            //instantiaties client object in Account Class     
            Account Client = new Account();
            Client.FirstName = firstName;
            Client.LastName = lastName;
            Client.City = city;
            Client.State = state;
            Client.Email = email;
            Client.TotalBalance = chDep + sDep + rDep;

            //clears console before displaying menu items
            Console.Clear();

            while (true)
            {
            Menu:
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
                    Console.WriteLine("\nPlease enter a valid number");
                    string userInput2 = Console.ReadLine();
                    userInput = userInput2;
                }

                //bypasses error if user enters a letter
                value = -1;
                while (!int.TryParse(userInput, out value))
                {
                    Console.WriteLine("\nPlease enter a valid number");
                    string userInput2 = Console.ReadLine();
                    userInput = userInput2;
                }

                //stores user input as integer
                int input = int.Parse(userInput);

                //prevents user from entering values out of range
                while (input < 1 || input > 8)
                {
                    Console.WriteLine("\nPlease enter a valid number");
                    int input2 = int.Parse(Console.ReadLine());
                    input = input2;
                }

                //quit program
                if (input == 8)
                {
                    Console.Clear();
                    break;
                }

                //actions to be completed based on user input
                if (input == 1)
                {
                    Console.Clear();

                    Client.DisplayInfo();

                    Console.WriteLine("\nPress any key to access main menu...\n");
                    Console.ReadKey();
                    goto Menu;
                }
                else if (input == 2)
                {
                    Console.Clear();

                    Client.DisplayTotalBalance();

                    Console.WriteLine("\nPress any key to access main menu...\n");
                    Console.ReadKey();
                    goto Menu;
                }
                else if (input == 3)
                {
                    Console.Clear();

                    CheckingAccount.DisplayBalance();

                    Console.WriteLine("\nPress any key to access main menu...\n");
                    Console.ReadKey();
                    goto Menu;
                }
                else if (input == 4)
                {
                    Console.Clear();
                    SavingAccount.DisplayBalance();
                    Console.WriteLine("\nPress any key to access main menu...\n");
                    Console.ReadKey();
                    goto Menu;
                }
                else if (input == 5)
                {
                    Console.Clear();

                    ReserveAccount.DisplayBalance();

                    Console.WriteLine("\nPress any key to access main menu...\n");
                    Console.ReadKey();
                    goto Menu;
                }
                else if (input == 6)
                {
                    Console.Clear();

                    Console.WriteLine("To which account would you like to make a deposit?\n");
                    Console.WriteLine("1 - Checking\n2 - Saving\n3 - Reserve\n");
                    string acctInput = Console.ReadLine();

                                //bypasses error if user presses enter without entering value
                                //bypasses error if user enters a letter
                                value = -1;
                                while (!int.TryParse(acctInput, out value) || acctInput == "")
                                {
                                    Console.WriteLine("\nPlease enter a valid number\n");
                                    string acctInput2 = Console.ReadLine();
                                    acctInput = acctInput2;
                                }

                                //stores user input as integer
                                int acct = int.Parse(acctInput);

                                //prevents user from entering values out of range
                                while (acct < 1 || acct > 3)
                                {
                                    Console.WriteLine("\nPlease enter a valid number\n");
                                    int acct2 = int.Parse(Console.ReadLine());
                                    acct = acct2;
                                }
                    
                    if (acct == 1)
                    {
                        Console.WriteLine("\nHow much would you like to deposit into your Checking Account?\n");
                        string depInput = Console.ReadLine();

                                //bypasses error if user presses enter without entering value
                                //bypasses error if user enters a letter
                                value = -1;
                                while (!int.TryParse(depInput, out value) || depInput == "")
                                {
                                    Console.WriteLine("\nPlease enter a valid number\n");
                                    string depInput2 = Console.ReadLine();
                                    depInput = depInput2;
                                }

                                //stores user input as integer
                                int dep = int.Parse(depInput);

                                //prevents user from entering values out of range
                                while (dep <= 0)
                                {
                                    Console.WriteLine("\nPlease enter a valid number\n");
                                    int dep2 = int.Parse(Console.ReadLine());
                                    dep = dep2;
                                }

                        CheckingAccount.Deposit(dep);
                        CheckingAccount.DisplayBalance();
                    }
                    else if (acct == 2)
                    {
                        Console.WriteLine("\nHow much would you like to deposit into your Saving Account?\n");
                        string depInput = Console.ReadLine();

                                    //bypasses error if user presses enter without entering value
                                    //bypasses error if user enters a letter
                                    value = -1;
                                    while (!int.TryParse(depInput, out value) || depInput == "")
                                    {
                                        Console.WriteLine("\nPlease enter a valid number\n");
                                        string depInput2 = Console.ReadLine();
                                        depInput = depInput2;
                                    }

                                    //stores user input as integer
                                    int dep = int.Parse(depInput);

                                    //prevents user from entering values out of range
                                    while (dep <= 0)
                                    {
                                        Console.WriteLine("\nPlease enter a valid number\n");
                                        int dep2 = int.Parse(Console.ReadLine());
                                        dep = dep2;
                                    }

                        SavingAccount.Deposit(dep);
                        SavingAccount.DisplayBalance();
                    }
                    else if (acct == 3)
                    {
                        Console.WriteLine("\nHow much would you like to deposit into your Reserve Account?\n");
                        string depInput = Console.ReadLine();

                                    //bypasses error if user presses enter without entering value
                                    //bypasses error if user enters a letter
                                    value = -1;
                                    while (!int.TryParse(depInput, out value) || depInput == "")
                                    {
                                        Console.WriteLine("\nPlease enter a valid number\n");
                                        string depInput2 = Console.ReadLine();
                                        depInput = depInput2;
                                    }

                                    //stores user input as integer
                                    int dep = int.Parse(depInput);

                                    //prevents user from entering values out of range
                                    while (dep <= 0)
                                    {
                                        Console.WriteLine("\nPlease enter a valid number\n");
                                        int dep2 = int.Parse(Console.ReadLine());
                                        dep = dep2;
                                    }

                        ReserveAccount.Deposit(dep);
                        ReserveAccount.DisplayBalance();
                    }

                    Console.WriteLine("\nPress any key to access main menu...\n");
                    Console.ReadKey();
                    goto Menu;
                }
                else if (input == 7)
                {
                    Console.Clear();

                    Console.WriteLine("From which account would you like to make a withdrawal?\n");
                    Console.WriteLine("1 - Checking\n2 - Saving\n3 - Reserve\n");
                    string acctInput = Console.ReadLine();

                                //bypasses error if user presses enter without entering value
                                //bypasses error if user enters a letter
                                value = -1;
                                while (!int.TryParse(acctInput, out value) || acctInput == "")
                                {
                                    Console.WriteLine("\nPlease enter a valid number\n");
                                    string acctInput2 = Console.ReadLine();
                                    acctInput = acctInput2;
                                }

                                //stores user input as integer
                                int acct = int.Parse(acctInput);

                                //prevents user from entering values out of range
                                while (acct < 1 || acct > 3)
                                {
                                    Console.WriteLine("\nPlease enter a valid number\n");
                                    int acct2 = int.Parse(Console.ReadLine());
                                    acct = acct2;
                                }

                    if (acct == 1)
                    {
                        Console.WriteLine("\nHow much would you like to withdraw from your Checking Account?\n");
                        string withInput = Console.ReadLine();

                                    //bypasses error if user presses enter without entering value
                                    //bypasses error if user enters a letter
                                    value = -1;
                                    while (!int.TryParse(withInput, out value) || withInput == "")
                                    {
                                        Console.WriteLine("\nPlease enter a valid number\n");
                                        string withInput2 = Console.ReadLine();
                                        withInput = withInput2;
                                    }

                                    //stores user input as integer
                                    int with = int.Parse(withInput);

                                    //prevents user from entering values out of range
                                    while (with <= 0)
                                    {
                                        Console.WriteLine("\nPlease enter a valid number\n");
                                        int with2 = int.Parse(Console.ReadLine());
                                        with = with2;
                                    }

                        CheckingAccount.Withdraw(with);
                        CheckingAccount.DisplayBalance();
                    }
                    else if (acct == 2)
                    {
                        Console.WriteLine("\nHow much would you like to withdraw from your Saving Account?\n");
                        string withInput = Console.ReadLine();

                                    //bypasses error if user presses enter without entering value
                                    //bypasses error if user enters a letter
                                    value = -1;
                                    while (!int.TryParse(withInput, out value) || withInput == "")
                                    {
                                        Console.WriteLine("\nPlease enter a valid number\n");
                                        string withInput2 = Console.ReadLine();
                                        withInput = withInput2;
                                    }

                                    //stores user input as integer
                                    int with = int.Parse(withInput);

                                    //prevents user from entering values out of range
                                    while (with <= 0)
                                    {
                                        Console.WriteLine("\nPlease enter a valid number\n");
                                        int with2 = int.Parse(Console.ReadLine());
                                        with = with2;
                                    }

                        SavingAccount.Withdraw(with);
                        SavingAccount.DisplayBalance();
                    }
                    else if (acct == 3)
                    {
                        Console.WriteLine("\nHow much would you like to withdraw from your Reserve Account?\n");
                        string withInput = Console.ReadLine();

                                    //bypasses error if user presses enter without entering value
                                    //bypasses error if user enters a letter
                                    value = -1;
                                    while (!int.TryParse(withInput, out value) || withInput == "")
                                    {
                                        Console.WriteLine("\nPlease enter a valid number\n");
                                        string withInput2 = Console.ReadLine();
                                        withInput = withInput2;
                                    }

                                    //stores user input as integer
                                    int with = int.Parse(withInput);

                                    //prevents user from entering values out of range
                                    while (with <= 0)
                                    {
                                        Console.WriteLine("\nPlease enter a valid number\n");
                                        int with2 = int.Parse(Console.ReadLine());
                                        with = with2;
                                    }

                        ReserveAccount.Withdraw(with);
                        ReserveAccount.DisplayBalance();
                    }

                    Console.WriteLine("\nPress any key to access main menu...\n");
                    Console.ReadKey();
                    goto Menu;
                }
            }
        }
    }
}
