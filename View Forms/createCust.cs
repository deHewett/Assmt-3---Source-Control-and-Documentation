using System;
using System.Collections;
using System.Windows.Forms;

namespace Assmt_2___GUI_Debugging_and_Testing.View_Forms
{
    /// <summary>
    /// create customer form
    /// </summary>
    public partial class createCust : Assmt_2___GUI_Debugging_and_Testing.branding
    {
        public createCust()
        {
            InitializeComponent();
        }
        /// <summary>
        /// constructor with reference to the list of customers
        /// </summary>
        /// <param name="custList"></param>
        public createCust(ArrayList custList)
        {
            InitializeComponent();
            int idCount;

            for (int i = 0; i < custList.Count + 1; i++)
            {
                if (i > ((Customer)custList[i]).CustomerID)
                {
                    idCount = i;
                    break;
                }
            }
        }
        /// <summary>
        /// closes the current form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void cancelCust_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// calls the controller to add the new customer to the customer list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void submitCust_Click(object sender, EventArgs e)
        {
            if (fNameInput.Text == "" || lNameInput.Text == "" || phNumInput.Text == "" || emailInput.Text == "")
            {
                MessageBox.Show("Please fill in required fields", "Form Error");
            }
            else
            {
                Controller.Controller.submitCust(new Customer(fNameInput.Text, lNameInput.Text, int.Parse(phNumInput.Text), emailInput.Text, staffCheckBox.Checked));
                Close();
            }

        }

    }
}
