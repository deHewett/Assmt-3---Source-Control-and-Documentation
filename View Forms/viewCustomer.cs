using Assmt_2___GUI_Debugging_and_Testing.Models;
using System;
using System.Windows.Forms;

namespace Assmt_2___GUI_Debugging_and_Testing.View_Forms
{
    /// <summary>
    /// view customer form
    /// </summary>
    public partial class viewCustomer : Assmt_2___GUI_Debugging_and_Testing.branding
    {
        int pointer;
        /// <summary>
        /// default viewCustomer constructor
        /// </summary>
        public viewCustomer()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Constructor with reference to selected customer
        /// </summary>
        /// <param name="cust"></param>
        public viewCustomer(Customer cust)
        {
            pointer = Controller.Controller.custAList.IndexOf(cust);
            InitializeComponent();
            custFName.Text = cust.FirstName;
            custLName.Text = cust.LastName;
            custPhNum.Text = cust.PhoneNumber.ToString();
            custEmail.Text = cust.EmailAddress;
            for (int i = 0; i < cust.Accounts.Count; i++)
            {
                string accountType = ""; ;
                // check what account type each object is in the list and displays the relevant data
                if (cust.Accounts[i].GetType() == typeof(Account))
                {
                    accountType = "Everyday";
                }
                else if (cust.Accounts[i].GetType() == typeof(Investment))
                {
                    accountType = "Investment";
                }
                else if (cust.Accounts[i].GetType() == typeof(Omni))
                {
                    accountType = "Omni";
                }
                accountsCombo.Items.Add(accountType + " Balance: " + ((Account)cust.Accounts[i]).balance);
            }
        }
        /// <summary>
        /// updates the accounts list whenever a change is made to it
        /// </summary>
        public void updateAccounts()
        {
            accountsCombo.SelectedIndex = -1;
            accountsCombo.Items.Clear();
            amountInput.Text = "";

            for (int i = 0; i < ((Customer)Controller.Controller.custAList[pointer]).Accounts.Count; i++)
            {
                string accountType = ""; ;
                if (((Customer)Controller.Controller.custAList[pointer]).Accounts[i].GetType() == typeof(Account))
                {
                    accountType = "Everyday";
                }
                else if (((Customer)Controller.Controller.custAList[pointer]).Accounts[i].GetType() == typeof(Investment))
                {
                    accountType = "Investment";
                }
                else if (((Customer)Controller.Controller.custAList[pointer]).Accounts[i].GetType() == typeof(Omni))
                {
                    accountType = "Omni";
                }
                accountsCombo.Items.Add(accountType + " Balance: " + ((Account)((Customer)Controller.Controller.custAList[pointer]).Accounts[i]).balance.ToString());
            }
        }
        /// <summary>
        /// closes the current form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// calls the controller to open the transfer form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void transferBtn_Click(object sender, EventArgs e)
        {
            Controller.Controller.accountTransfer((Customer)Controller.Controller.custAList[pointer], this);
        }
        /// <summary>
        /// calls the controller to open the new account form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newAccountBtn_Click(object sender, EventArgs e)
        {
            Controller.Controller.openAccountForm((Customer)Controller.Controller.custAList[pointer]);
        }
        /// <summary>
        /// calls the controller to add the text input float to the account balance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void depositBtn_Click(object sender, EventArgs e)
        {
            ((Account)((Customer)Controller.Controller.custAList[pointer]).Accounts[(accountsCombo.SelectedIndex)]).deposit(float.Parse(amountInput.Text));
            updateAccounts();
        }
        /// <summary>
        /// calls the controller to deduct the text input float from the account balance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            ((Account)((Customer)Controller.Controller.custAList[pointer]).Accounts[(accountsCombo.SelectedIndex)]).withdraw(float.Parse(amountInput.Text));
            updateAccounts();
        }
    }
}
