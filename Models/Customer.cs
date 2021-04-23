using Assmt_2___GUI_Debugging_and_Testing.Models;
using System;
using System.Collections;

namespace Assmt_2___GUI_Debugging_and_Testing
{
    /// <summary>
    /// Customer class. Holds customer information, whether they are staff or not and a list of any accounts they have
    /// </summary>
    [Serializable]
    public class Customer
    {

        public static int customerIDCounter = 0;
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public bool staff { get; set; }
        public ArrayList Accounts = new ArrayList();
        public Account customerAccount = new Account();
        public Random rand = new Random();

        /// <summary>
        /// Default constructor filling all variables with dummy data
        /// </summary>
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
            Accounts.Add(new Investment(this, Convert.ToSingle(rDouble = rand.NextDouble() * range)));
            Accounts.Add(new Omni(this, Convert.ToSingle(rDouble = rand.NextDouble() * range)));
            customerIDCounter++;

        }
        /// <summary>
        /// Customer constructor that takes user input for all fields excluding the customer ID
        /// </summary>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="PhoneNumber"></param>
        /// <param name="EmailAddress"></param>
        /// <param name="staff"></param>
        public Customer(string FirstName, string LastName,
            int PhoneNumber, string EmailAddress, bool staff)
        {
            CustomerID = customerIDCounter;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
            this.EmailAddress = EmailAddress;
            this.staff = staff;
            rand = new Random();
            int rInt = rand.Next(0, 100);
            int range = 2000;
            double rDouble = rand.NextDouble() * range;
            Accounts.Add(new Account(this, Convert.ToSingle(rDouble = rand.NextDouble() * range)));
            Accounts.Add(new Investment(this, Convert.ToSingle(rDouble = rand.NextDouble() * range)));
            Accounts.Add(new Omni(this, Convert.ToSingle(rDouble = rand.NextDouble() * range)));
            customerIDCounter++;
        }
        /// <summary>
        /// Customer constructor that takes user input for all fields excluding customer ID, customer ID
        /// is passed into it from other functions. The user cannot change their ID in any way
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="PhoneNumber"></param>
        /// <param name="EmailAddress"></param>
        /// <param name="staff"></param>
        public Customer(int ID, string FirstName, string LastName,
            int PhoneNumber, string EmailAddress, bool staff)
        {
            CustomerID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
            this.EmailAddress = EmailAddress;
            this.staff = staff;

        }
        /// <summary>
        /// Adds an everyday (Account) into the account array list with no balance
        /// </summary>
        public void createEveryday()
        {
            Accounts.Add(new Account(this));
        }
        /// <summary>
        /// Adds an everyday (Account) into the account array list with a starting balance
        /// </summary>
        /// <param name="balance"></param>
        public void createEveryday(float balance)
        {
            Accounts.Add(new Account(this, balance));
        }
        /// <summary>
        /// Adds an Investment account into the account array list with no balance
        /// </summary>
        public void createInvestment()
        {
            Accounts.Add(new Investment(this));
        }
        /// <summary>
        /// Adds an Investment account into the account array list with a starting balance
        /// </summary>
        /// <param name="balance"></param>
        public void createInvestment(float balance)
        {
            Accounts.Add(new Investment(this, balance));
        }
        /// <summary>
        /// Adds an omni account into the account array list with no balance
        /// </summary>
        public void createOmni()
        {
            Accounts.Add(new Omni(this));
        }
        /// <summary>
        /// Adds an omni account into the account array list with a starting balance
        /// </summary>
        /// <param name="balance"></param>
        public void createOmni(float balance)
        {
            Accounts.Add(new Omni(this, balance));
        }
        /// <summary>
        /// Adds an omni account into the account array list with a starting balance and available overdraft
        /// Overdraft is redundant for this assignment
        /// </summary>
        /// <param name="balance"></param>
        /// <param name="overdraft"></param>
        public void createOmni(float balance, float overdraft)
        {
            Accounts.Add(new Omni(this, balance, overdraft));
        }
    }
}

