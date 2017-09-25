using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Client
    {
        //fields
        private string firstName;
        private string lastName;
        private string emailAddress;
        private int clientIDNumber;

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

        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        public int ClientIDNumber
        {
            get { return clientIDNumber; }
            set { clientIDNumber = value; }
        }
        //constructors

        //public Client()
        //{ }

        public Client(string firstName, string lastName, string emailAddress, int clientIDNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.clientIDNumber = clientIDNumber;
        }

        //methods
        public void CustomerInformation()
        {
            Console.WriteLine($"\nCustomer Name:\t\t{firstName} {lastName}");
            Console.WriteLine($"Customer Email:\t\t{emailAddress}");
            Console.WriteLine($"Customer ID:\t\t{clientIDNumber}");
            Console.WriteLine("\nPress Enter to return to the Main Menu");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
