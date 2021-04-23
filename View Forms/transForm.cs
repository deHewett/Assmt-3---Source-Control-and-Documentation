using Assmt_2___GUI_Debugging_and_Testing.Models;
using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;


namespace Assmt_2___GUI_Debugging_and_Testing.View_Forms
{
    /// <summary>
    /// transfer form class
    /// </summary>
    public partial class transForm : Assmt_2___GUI_Debugging_and_Testing.branding
    {
        public static viewCustomer currentCustForm = Application.OpenForms.OfType<viewCustomer>().FirstOrDefault();
        int pointer;
        public transForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// constructor with reference to the selected customer making the transfers
        /// </summary>
        /// <param name="cust"></param>
        public transForm(Customer cust)
        {
            InitializeComponent();
            pointer = Controller.Controller.custAList.IndexOf(cust);
            updateAccounts();
        }
        /// <summary>
        /// closes the current form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeBtn_Click(object sender, EventArgs e)
        {
            currentCustForm.updateAccounts();
            this.Close();
        }
        /// <summary>
        /// updates the account list to show any changes made
        /// </summary>
        private void updateAccounts()
        {
            transferFromCombo.SelectedIndex = -1;
            transferToCombo.SelectedIndex = -1;
            transferFromCombo.Items.Clear();
            transferToCombo.Items.Clear();
            transferAmountInput.Text = "";

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


                transferFromCombo.Items.Add(accountType + " Balance: " + ((Account)((Customer)Controller.Controller.custAList[pointer]).Accounts[i]).balance.ToString());
                transferToCombo.Items.Add(accountType + " Balance: " + ((Account)((Customer)Controller.Controller.custAList[pointer]).Accounts[i]).balance.ToString());


            }
        }
        /// <summary>
        /// transfers the input amount between accounts. if the same account is selected the user is prompted to select seperate accounts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void transferBtn_Click(object sender, EventArgs e)
        {
            if (transferFromCombo.SelectedItem == transferToCombo.SelectedItem)
            {
                string message = "Please choose seperate accounts to transfer funds between.";
                string title = "Transfer Error";
                MessageBox.Show(message, title);
            }

            else if (((Account)((Customer)Controller.Controller.custAList[pointer]).Accounts[transferFromCombo.SelectedIndex]).balance >= float.Parse(transferAmountInput.Text))
            {
                ((Account)((Customer)Controller.Controller.custAList[pointer]).Accounts[transferFromCombo.SelectedIndex]).withdraw(float.Parse(transferAmountInput.Text));
                ((Account)((Customer)Controller.Controller.custAList[pointer]).Accounts[transferToCombo.SelectedIndex]).deposit(float.Parse(transferAmountInput.Text));
                updateAccounts();
            }
            else
            {
                ((Account)((Customer)Controller.Controller.custAList[pointer]).Accounts[transferFromCombo.SelectedIndex]).withdraw(float.Parse(transferAmountInput.Text));
                updateAccounts();
            }
        }
        /// <summary>
        /// iterates through a loop calculating interest on all accounts of the customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calcIntBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ((Customer)Controller.Controller.custAList[pointer]).Accounts.Count; i++)
            {
                if (((Account)((Customer)Controller.Controller.custAList[pointer]).Accounts[i]).GetType() == typeof(Account))
                {
                    ((Account)((Customer)Controller.Controller.custAList[pointer]).Accounts[i]).calcInterest();
                }
                else if (((Customer)Controller.Controller.custAList[pointer]).Accounts[i].GetType() == typeof(Investment))
                {
                    ((Investment)((Customer)Controller.Controller.custAList[pointer]).Accounts[i]).calcInterest();
                }
                else if (((Customer)Controller.Controller.custAList[pointer]).Accounts[i].GetType() == typeof(Omni))
                {
                    ((Omni)((Customer)Controller.Controller.custAList[pointer]).Accounts[i]).calcInterest();
                }

            }
        }
    }
}

