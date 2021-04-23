using System;
using System.Windows.Forms;

namespace Assmt_2___GUI_Debugging_and_Testing.View_Forms
{
    /// <summary>
    /// edit customer form
    /// </summary>
    public partial class editCust : Assmt_2___GUI_Debugging_and_Testing.branding
    {
        private Customer originalCust;

        public editCust()
        {
            InitializeComponent();

        }
        /// <summary>
        /// constructor with reference to the selected customer for edit
        /// </summary>
        /// <param name="cust"></param>
        public editCust(Customer cust)
        {
            originalCust = cust;
            InitializeComponent();
            fNameInput.Text = originalCust.FirstName;
            lNameInput.Text = originalCust.LastName;
            phNumInput.Text = originalCust.PhoneNumber.ToString();
            emailInput.Text = originalCust.EmailAddress;
            staffCheckBox.Checked = originalCust.staff;
        }
        /// <summary>
        /// calls the controller with the new customer object to replace the previous
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitCust_Click(object sender, EventArgs e)
        {
            Controller.Controller.submitEdit(originalCust, new Customer(originalCust.CustomerID, fNameInput.Text, lNameInput.Text, int.Parse(phNumInput.Text), emailInput.Text, staffCheckBox.Checked));
            Controller.Controller.homeForm.updateList();
            MessageBox.Show("Customer information has been saved!", "Update Confirmed");
            Close();
        }
        /// <summary>
        /// closes the current form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelCust_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
