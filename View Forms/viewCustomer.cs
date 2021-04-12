using Assmt_2___GUI_Debugging_and_Testing.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Assmt_2___GUI_Debugging_and_Testing.View_Forms
{
    public partial class viewCustomer : Assmt_2___GUI_Debugging_and_Testing.branding
    {
        public viewCustomer()
        {
            InitializeComponent();
            
        }
        Customer activeCust;

        public viewCustomer(Customer cust)
        {
            activeCust = cust;
            InitializeComponent();
            custFName.Text = cust.FirstName;
            custLName.Text = cust.LastName;
            custPhNum.Text = cust.PhoneNumber.ToString();
            custEmail.Text = cust.EmailAddress;
            for(int i =0; i<cust.Accounts.Count; i++)
            {
                string accountType = ""; ;
                if(cust.Accounts[i].GetType() == typeof(Account))
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


        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void transferBtn_Click(object sender, EventArgs e)
        {
            Controller.Controller.accountTransfer(activeCust);
        }
    }
}
