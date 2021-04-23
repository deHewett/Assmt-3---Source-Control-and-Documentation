using System;
using System.Windows.Forms;

namespace Assmt_2___GUI_Debugging_and_Testing
{
    public partial class Form1 : Assmt_2___GUI_Debugging_and_Testing.branding
    {
        /// <summary>
        /// Form1 (Was renamed to manageCustomers but references caused errors) is the main form for all application functionality
        /// </summary>
        public Form1()
        {
            /// Loads the customer list and id count from a serialized binary file
            Controller.Controller.deserialize_and_load();
            InitializeComponent();
            if (Controller.Controller.custAList.Count > 0) updateList();
        }
        /// <summary>
        /// editCust_Click checks if a Customer has been selected from the list box. If a customer has been selected it calls the
        /// controller to open the editCust form otherwise it informs the user no Customer was selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editCust_Click(object sender, EventArgs e)
        {
            if (custList.SelectedIndex == -1)
            {
                Console.WriteLine("No item selected");
            }
            else
            {
                string[] split = custList.SelectedItem.ToString().Split();
                int custID = int.Parse(split[0]);
                Controller.Controller.editCust((Customer)Controller.Controller.custAList[custID]);
            }

        }
        /// <summary>
        /// submitCustForm recieves the Customer object from the controller and adds its details to the list box
        /// </summary>
        /// <param name="cust"></param>
        public void submitCustForm(Customer cust)
        {
            custList.Items.Add(cust.CustomerID + " " + cust.FirstName + " " + cust.LastName);
        }
        /// <summary>
        /// updateList clears and reloads the list box with the up to date customer information. This is called whenever
        /// there are changes made to a customer
        /// </summary>
        public void updateList()
        {
            Console.WriteLine("Update method called");
            custList.Items.Clear();
            custList.BeginUpdate();
            for (int i = 0; i < Controller.Controller.custAList.Count; i++)
            {
                Customer cust = (Customer)Controller.Controller.custAList[i];
                custList.Items.Add(cust.CustomerID + " " + cust.FirstName + " " + cust.LastName);
            }
            custList.EndUpdate();
            Console.WriteLine("Update method ended");
        }
        /// <summary>
        /// dltCust_Click checks if a customer has been selected from the list box. If a customer has been selected it sends that customer
        /// object to the controller to open the delete customer form otherwise it informs the user no customer has been selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                for (int i = 0; i <= Controller.Controller.custAList.Count; i++)
                {
                    if (custID == ((Customer)Controller.Controller.custAList[i]).CustomerID)
                    {
                        Controller.Controller.deleteCustomer((Customer)Controller.Controller.custAList[custID]);
                        break;
                    }
                }
            }
        }
        /// <summary>
        /// searchCustClick takes a string from the search bar and calls the controller to filter the customer list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchCust_Click(object sender, EventArgs e)
        {
            Controller.Controller.findCustomer(searchBox.Text, custList, this);
        }
        /// <summary>
        /// Exit saves the customer list and id count into a serialized binary file and closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exit_Click(object sender, EventArgs e)
        {
            Controller.Controller.serialize_and_close();
            Application.Exit();
        }
        /// <summary>
        /// Alternate save method if the user closes the form without pressing the exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            Console.WriteLine(Controller.Controller.custAList);
            Console.WriteLine(Customer.customerIDCounter);
            Controller.Controller.serialize_and_close();
        }
        /// <summary>
        /// viewCust opens the form related to the selected customer. If no customer is selected it prompts the user to select a customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewCust_Click(object sender, EventArgs e)
        {
            if(custList.SelectedItem == null)
            {
                MessageBox.Show("Please select a customer", "Select Customer");
                return;
            }
            string[] splitString = custList.SelectedItem.ToString().Split();
            for (int i = 0; i < Controller.Controller.custAList.Count; i++)
            {
                if (splitString[1] == ((Customer)Controller.Controller.custAList[i]).FirstName &&
                    splitString[2] == ((Customer)Controller.Controller.custAList[i]).LastName)
                {
                    Controller.Controller.viewCustomer((Customer)Controller.Controller.custAList[i]);
                }
            }

        }
        /// <summary>
        /// Calls the controller to open the add customer form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addCust_Click(object sender, EventArgs e)
        {
            Controller.Controller.addCust();
        }
        /// <summary>
        /// This event is a cheap work around due to the form1 reference being null all of a sudden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Shown(object sender, EventArgs e)
        {
            Controller.Controller.referenceForm1();
        }
    }
}
