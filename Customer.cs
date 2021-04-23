using Assmt_2___GUI_Debugging_and_Testing.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Name space is as follows as the project continues on from the previous assignment.
namespace Assmt_2___GUI_Debugging_and_Testing
{
    public class Customer
    {
        static int customerIDCounter = 0;
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public ArrayList Accounts = new ArrayList();
        public Account customerAccount = new Account();
        public Random rand = new Random();


        public Customer()
        {
            CustomerID = customerIDCounter;
            FirstName = "Joe";
            LastName = "Bloggs";
            PhoneNumber = 123456789;
            EmailAddress = "jbloggs@gmail.com";
            rand = new Random();
            int rInt = rand.Next(0, 100);
            int range = 2000;
            double rDouble = rand.NextDouble() * range;
            Accounts.Add(new Account(this, Convert.ToSingle(rDouble = rand.NextDouble() * range)));
            Accounts.Add(new Investment(this, Convert.ToSingle(rDouble = rand.NextDouble()*range)));
            Accounts.Add(new Omni(this, Convert.ToSingle(rDouble = rand.NextDouble() * range)));
            customerIDCounter++;

        }
        public Customer(string FirstName, string LastName,
            int PhoneNumber, string EmailAddress)
        {
            CustomerID = customerIDCounter;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
            this.EmailAddress = EmailAddress;
            rand = new Random();
            int rInt = rand.Next(0, 100);
            int range = 2000;
            double rDouble = rand.NextDouble() * range;
            Accounts.Add(new Account(this, Convert.ToSingle(rDouble = rand.NextDouble() * range)));
            Accounts.Add(new Investment(this, Convert.ToSingle(rDouble = rand.NextDouble() * range)));
            Accounts.Add(new Omni(this, Convert.ToSingle(rDouble = rand.NextDouble() * range)));
            customerIDCounter++;
        }
        public Customer(int ID, string FirstName, string LastName,
            int PhoneNumber, string EmailAddress, Account custAccount)
        {
            CustomerID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
            this.EmailAddress = EmailAddress;
            customerAccount = custAccount;
            
        }
        public void createEveryday()
        {
            Accounts.Add(new Account(this));
        }
        public void createEveryday(float balance)
        {
            Accounts.Add(new Account(this, balance));
        }
        public void createInvestment()
        {
            Accounts.Add(new Investment(this));
        }
        public void createInvestment(float balance)
        {
            Accounts.Add(new Investment(this, balance));
        }
        public void createOmni()
        {
            Accounts.Add(new Omni(this));
        }
        public void createOmni(float balance)
        {
            Accounts.Add(new Omni(this, balance));
        }
        public void createOmni(float balance, float overdraft)
        {
            Accounts.Add(new Omni(this, balance, overdraft));
        }
    }
}

