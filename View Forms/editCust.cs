using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Assmt_2___GUI_Debugging_and_Testing.View_Forms
{
    public partial class editCust : Assmt_2___GUI_Debugging_and_Testing.branding
    {
        private Customer originalCust;

        public editCust()
        {
            InitializeComponent();
        }
        public editCust(Customer cust)
        {
            originalCust = cust;
            InitializeComponent();
        }

        private void submitCust_Click(object sender, EventArgs e)
        {
            Controller.Controller.submitEdit(originalCust, new Customer(originalCust.CustomerID, fNameInput.Text, lNameInput.Text, int.Parse(phNumInput.Text), emailInput.Text, originalCust.customerAccount));
            Controller.Controller.homeForm.updateList();
            Close();
        }

        private void cancelCust_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
