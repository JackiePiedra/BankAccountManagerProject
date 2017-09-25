using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Savings : Accounts
    {
        private decimal minimumBalance = 250m;

        public decimal MinimumBalance
        { get { return this.minimumBalance; } }


        //constructor
        public Savings(int accountNumber, decimal AccountBalance)
        {
            this.accountNumber = accountNumber;
            this.AccountBalance = AccountBalance;
            this.AccountType = "savings";
        }

        //methods
        public override void DepositFunds(decimal depositAmount)
        {
            this.AccountBalance += depositAmount;

        }

        public override void WithdrawFunds(decimal withdrawalAmount)
        {
            if (this.AccountBalance < withdrawalAmount)
            {
                Console.WriteLine("\nYou do not have sufficient funds for this withdrawal");
            }
            else
            {
                this.AccountBalance -= withdrawalAmount;
            }
        }
    }
}