using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Assmt_2___GUI_Debugging_and_Testing.View_Forms
{
    public partial class deleteCust : Assmt_2___GUI_Debugging_and_Testing.branding
    {
        private Customer originalCust;

        public deleteCust()
        {
            InitializeComponent();
        }
        public deleteCust(Customer cust)
        {
            originalCust = cust;
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Controller.Controller.submitDelete(originalCust);
            Close();
        }
    }
}
