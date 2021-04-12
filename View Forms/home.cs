using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Assmt_2___GUI_Debugging_and_Testing
{
    public partial class home : Assmt_2___GUI_Debugging_and_Testing.branding
    {
        public home()
        {
            InitializeComponent();
        }

        private void mngCustBtn_Click(object sender, EventArgs e)
        {
            Form1 manageCustForm = new Form1();
            manageCustForm.Show();
            Close();
        }
    }
}
