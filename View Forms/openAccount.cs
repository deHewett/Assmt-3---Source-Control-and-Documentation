using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assmt_2___GUI_Debugging_and_Testing.View_Forms
{
    /// <summary>
    /// Open Account class form that creates forms for the selected customer.
    /// </summary>
    public partial class openAccount : Assmt_2___GUI_Debugging_and_Testing.branding
    {
        Customer activeCust;
        viewCustomer formReference = Application.OpenForms.OfType<viewCustomer>().FirstOrDefault();
        
        public openAccount()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Form constructor that takes the customer from the previous form
        /// </summary>
        /// <param name="cust"></param>
        public openAccount(Customer cust)
        {
            activeCust = cust;
            InitializeComponent();
            custFName.Text = cust.FirstName;
            custLName.Text = cust.LastName;
            accountSelectCombo.Items.AddRange(new string[] { "Everyday", "Investment", "Omni" });
        }
        /// <summary>
        /// Creates the relevant account type based on the user input through a combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            int pointer = Controller.Controller.custAList.IndexOf(activeCust);
            /// switch case to determine which account type is selected. Tidier than an if statement
            /// if no account type is selected it prompts the user to select an account type
            switch (accountSelectCombo.SelectedItem)
            {
                case "Everyday":
                    ((Customer)Controller.Controller.custAList[pointer]).createEveryday(float.Parse(balanceInput.Text));
                    MessageBox.Show("Everyday account has been opened for " + activeCust.FirstName + " " + activeCust.LastName, "Opened Everyday Account");
                    break;
                case "Investment":
                    ((Customer)Controller.Controller.custAList[pointer]).createInvestment(float.Parse(balanceInput.Text));
                    MessageBox.Show("Investment account has been opened for " + activeCust.FirstName + " " + activeCust.LastName, "Opened Investment Account");
                    break;
                case "Omni":
                    ((Customer)Controller.Controller.custAList[pointer]).createOmni(float.Parse(balanceInput.Text));
                    MessageBox.Show("Omni account has been opened for " + activeCust.FirstName + " " + activeCust.LastName, "Opened Omni Account");
                    break;
                default:
                    MessageBox.Show("Please select an account type you wish to open", "Select an Account Type");
                    break;
            }
        }
        /// <summary>
        /// Closes the current form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// updates the customers account list in the previous form to show changes instantly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            formReference.updateAccounts();
        }
    }
}
