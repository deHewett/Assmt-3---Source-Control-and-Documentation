using System;

namespace Assmt_2___GUI_Debugging_and_Testing
{
    public partial class home : Assmt_2___GUI_Debugging_and_Testing.branding
    {
        /// <summary>
        /// Initial form for the application. Serves no real purpose other than fulfilling assignment requirements
        /// </summary>
        public home()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Opens the manageCustomer form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mngCustBtn_Click(object sender, EventArgs e)
        {
            Form1 manageCustForm = new Form1();
            manageCustForm.Show();
        }
    }
}
