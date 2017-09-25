using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Client customer = new Client("Jackie", "Piedra", "jackie@email.com", 54132215);
            Checking customerChecking = new Checking(7806001, 5000m);
            Savings customerSavings = new Savings(7806002, 12000m);

            Console.WriteLine("Welcome to Bank Manager, {0}!", customer.FirstName);
            Console.ReadLine();

            int bankAccount;

            bool exit = true;
            do
            {
                MainMenu();
                int userSelection = int.Parse(Console.ReadLine());
                switch (userSelection)
                {
                    case 1:
                        customer.CustomerInformation();
                        break;
                    case 2:
                        BankAccountSelection();
                        bankAccount = int.Parse(Console.ReadLine());
                        if (bankAccount == 1)
                        {
                            customerChecking.CurrentBalance();
                            ResetToMenu();
                            break;
                        }
                        else if (bankAccount == 2)
                        {
                            customerSavings.CurrentBalance();
                            ResetToMenu();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nThat is not a valid entry");
                            ResetToMenu();
                            break;
                        }
                    case 3:
                        BankAccountSelection();
                        bankAccount = int.Parse(Console.ReadLine());
                        decimal depositAmount;
                        if (bankAccount == 1)
                        {
                            Console.WriteLine("\nEnter your deposit amount:");
                            depositAmount = decimal.Parse(Console.ReadLine());
                            customerChecking.DepositFunds(depositAmount);
                            customerChecking.CurrentBalance();
                            ResetToMenu();
                            break;
                        }
                        else if (bankAccount == 2)
                        {
                            Console.WriteLine("\nEnter your deposit amount:");
                            depositAmount = decimal.Parse(Console.ReadLine());
                            customerSavings.DepositFunds(depositAmount);
                            customerSavings.CurrentBalance();
                            ResetToMenu();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nThat is not a valid entry");
                            ResetToMenu();
                            break;
                        }
                    case 4:
                        BankAccountSelection();
                        bankAccount = int.Parse(Console.ReadLine());
                        decimal withdrawalAmount;
                        if (bankAccount == 1)
                        {
                            Console.WriteLine("\nEnter your withdrawal amount:");
                            withdrawalAmount = decimal.Parse(Console.ReadLine());
                            customerChecking.WithdrawFunds(withdrawalAmount);
                            customerChecking.CurrentBalance();
                            ResetToMenu();
                            break;
                        }
                        else if (bankAccount == 2)
                        {
                            if (customerSavings.AccountBalance < customerSavings.MinimumBalance)
                            {
                                Console.WriteLine("You must have a minimum balance of {0:c} in order to withdraw funds", customerSavings.MinimumBalance);
                                Console.WriteLine("Current Account Balance is {0:c}", customerSavings.AccountBalance);
                                ResetToMenu();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nEnter your withdrawal amount:");
                                withdrawalAmount = decimal.Parse(Console.ReadLine());
                                customerSavings.WithdrawFunds(withdrawalAmount);
                                customerSavings.CurrentBalance();
                                ResetToMenu();
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("That is not a valid entry");
                            ResetToMenu();
                            break;
                        }
                    case 5:
                        Console.WriteLine("Thank you for using Bank Manager!");
                        exit = false;
                        break;
                    default:
                        break;
                }

            } while (exit);


        }

        public static void MainMenu()
        {
            Console.WriteLine("Main Menu \n\nSelect an option:");
            Console.WriteLine("1. View Customer Information");
            Console.WriteLine("2. View Account Balance");
            Console.WriteLine("3. Deposit Funds");
            Console.WriteLine("4. Withdraw Funds");
            Console.WriteLine("5. Exit");
        }

        public static void BankAccountSelection()
        {
            Console.WriteLine("Select which bank account for this transaction: \n1.Checking \n2.Savings");
        }

        public static void ResetToMenu()
        {
            Console.WriteLine("\nPress Enter to return to the Main Menu");
            Console.ReadLine();
            Console.Clear();
        }


    }
}
