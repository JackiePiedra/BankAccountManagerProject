using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Checking : Accounts
    {

        //constructor
        public Checking(int accountNumber, decimal accountBalance)
        {
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
        }

        public override void DepositFunds(decimal depositAmount)
        {
            this.AccountBalance += depositAmount;

        }

        public override void WithdrawFunds(decimal withdrawalAmount)
        {
            if (withdrawalAmount <= this.AccountBalance)
            {
                this.AccountBalance -= withdrawalAmount;

            }
            else
            {
                Console.WriteLine("\nYou do not have sufficient funds for this withdrawal");
            }
        }
    }
}