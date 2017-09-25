using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    abstract class Accounts
    {
        //fields
        protected int accountNumber;
        protected string accountType;
        protected decimal accountBalance;
        protected decimal depositAmount;
        protected decimal withdrawalAmount;

        //properties
        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }

        public string AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value; }
        }

        public decimal AccountBalance
        {
            get { return this.accountBalance; }
            set { this.accountBalance = value; }
        }

        //constructors
        public Accounts()
        {
        }

        //methods
        public virtual void CurrentBalance()
        {
            Console.WriteLine("Current balance for {0} account {1} is {2:c}", AccountType, AccountNumber, AccountBalance);
        }

        public abstract void DepositFunds(decimal depositAmount);//virtual to give access in the derived classes, no body here

        public abstract void WithdrawFunds(decimal withdrawalAmount);

    }
}
