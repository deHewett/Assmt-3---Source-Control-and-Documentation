using Assmt_2___GUI_Debugging_and_Testing.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

// Name space is as follows as the project continues on from the previous assignment.
namespace Assmt_2___GUI_Debugging_and_Testing.View_Forms
{
    public partial class transForm : Assmt_2___GUI_Debugging_and_Testing.branding
    {
        public transForm()
        {
            InitializeComponent();
        }
        Customer activeCust;
        public transForm(Customer cust)
        {
            InitializeComponent();
            activeCust = cust;
            updateAccounts();

            
            
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void updateAccounts()
        {
            transferFromCombo.SelectedIndex = -1;
            transferToCombo.SelectedIndex = -1;
            transferFromCombo.Items.Clear();
            transferToCombo.Items.Clear();

            for (int i = 0; i < activeCust.Accounts.Count; i++)
            {
                string accountType = ""; ;
                if (activeCust.Accounts[i].GetType() == typeof(Account))
                {
                    accountType = "Everyday";
                }
                else if (activeCust.Accounts[i].GetType() == typeof(Investment))
                {
                    accountType = "Investment";
                }
                else if (activeCust.Accounts[i].GetType() == typeof(Omni))
                {
                    accountType = "Omni";
                }


                transferFromCombo.Items.Add(accountType + " Balance: " + ((Account)activeCust.Accounts[i]).balance.ToString());
                transferToCombo.Items.Add(accountType + " Balance: " + ((Account)activeCust.Accounts[i]).balance.ToString());

                
            }
        }

        private void transferBtn_Click(object sender, EventArgs e)
        {
            if (transferFromCombo.SelectedItem == transferToCombo.SelectedItem)
            {
                string message = "Please choose seperate accounts to transfer funds between.";
                string title = "Transfer Error";
                MessageBox.Show(message, title);
            }

            else if (((Account)activeCust.Accounts[transferFromCombo.SelectedIndex]).balance >= float.Parse(transferAmountInput.Text))
            {
                ((Account)activeCust.Accounts[transferFromCombo.SelectedIndex]).withdraw(float.Parse(transferAmountInput.Text));
                ((Account)activeCust.Accounts[transferToCombo.SelectedIndex]).deposit(float.Parse(transferAmountInput.Text));
                updateAccounts();
            }
            else
            {
                ((Account)activeCust.Accounts[transferFromCombo.SelectedIndex]).withdraw(float.Parse(transferAmountInput.Text));
                updateAccounts();
            }
        }
    }
}
