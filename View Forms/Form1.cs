using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Assmt_2___GUI_Debugging_and_Testing
{
    public partial class Form1 : Assmt_2___GUI_Debugging_and_Testing.branding
    {
        public Form1()
        {
            InitializeComponent();
            Controller.Controller.homeForm = this;
        }

        private void editCust_Click(object sender, EventArgs e)
        {
            if(custList.SelectedIndex == -1)
            {
                Console.WriteLine("No item selected");
            } else
            {
                string[] split = custList.SelectedItem.ToString().Split();
                int custID = int.Parse(split[0]);
                Controller.Controller.editCust((Customer)Controller.Controller.custAList[custID]);
            }
            
        }

        private void addCust_Click(object sender, EventArgs e)
        {
            Controller.Controller.addCust();
        }
        public void submitCustForm(Customer cust)
        {
            custList.Items.Add(cust.CustomerID + " " + cust.FirstName + " " + cust.LastName);
        }
        public void updateList()
        {
            Console.WriteLine("Update method called");
            custList.Items.Clear();
            custList.BeginUpdate();
            for(int i=0; i<Controller.Controller.custAList.Count; i++)
            {
                Customer cust = (Customer)Controller.Controller.custAList[i];
                custList.Items.Add(cust.CustomerID + " " + cust.FirstName + " " + cust.LastName);
            }
            custList.EndUpdate();
            Console.WriteLine("Update method ended");
        }

        private void dltCust_Click(object sender, EventArgs e)
        {
            if (custList.SelectedIndex == -1)
            {
                Console.WriteLine("No item selected");
            }
            else
            {
                string[] split = custList.SelectedItem.ToString().Split();
                int custID = int.Parse(split[0]);
                Controller.Controller.deleteCustomer((Customer)Controller.Controller.custAList[custID]);
            }
        }

        private void searchCust_Click(object sender, EventArgs e)
        {
            Controller.Controller.findCustomer(searchBox.Text);
        }
    }
}
