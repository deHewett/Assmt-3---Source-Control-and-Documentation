using System;

namespace Assmt_2___GUI_Debugging_and_Testing.View_Forms
{
    /// <summary>
    /// delete customer form
    /// </summary>
    public partial class deleteCust : Assmt_2___GUI_Debugging_and_Testing.branding
    {
        private Customer originalCust;

        public deleteCust()
        {
            InitializeComponent();
        }
        /// <summary>
        /// constructor with reference to the target customer
        /// </summary>
        /// <param name="cust"></param>
        public deleteCust(Customer cust)
        {
            originalCust = cust;
            InitializeComponent();
        }
        /// <summary>
        /// closes the current form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// calls the controller to delete the selected customer from the customer list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Controller.Controller.submitDelete(originalCust);
            Close();
        }
    }
}
