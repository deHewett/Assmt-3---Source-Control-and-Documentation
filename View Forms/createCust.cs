using System;
using Assmt_2___GUI_Debugging_and_Testing.Controller;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Assmt_2___GUI_Debugging_and_Testing.View_Forms
{
    public partial class createCust : Assmt_2___GUI_Debugging_and_Testing.branding
    {
        public createCust()
        {
            InitializeComponent();
        }

        public void cancelCust_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void submitCust_Click(object sender, EventArgs e)
        {
            Controller.Controller.submitCust(new Customer(fNameInput.Text, lNameInput.Text, int.Parse(phNumInput.Text), emailInput.Text));
            Close();
        }

        private void fNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void custPhNumber_Click(object sender, EventArgs e)
        {

        }

        private void phNumInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void custEmail_Click(object sender, EventArgs e)
        {

        }

        private void emailInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void custFirstName_Click(object sender, EventArgs e)
        {

        }
    }
}
