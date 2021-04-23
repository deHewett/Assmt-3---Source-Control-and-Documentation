using Assmt_2___GUI_Debugging_and_Testing.View_Forms;
using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
namespace Assmt_2___GUI_Debugging_and_Testing.Controller
{
    /// <summary>
    /// The main controller for the application
    /// </summary>
    public static class Controller
    {
        public static ArrayList custAList = new ArrayList();
        public static Form1 homeForm;
        public static editCust editForm;
        
        // Add Customer related methods
        /// <summary>
        /// Opens a new customer form for user input
        /// </summary>

        public static void addCust()
        {
            createCust newCust = new createCust();
            newCust.ShowDialog();
        }

        public static void referenceForm1()
        {
            homeForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        }

        /// <summary>
        /// Is called when the create customer form is submitted and stores the
        /// data into the array list
        /// </summary>
        /// <param name="cust"></param>
        public static void submitCust(Customer cust)
        {
            Customer newCust = cust;
            custAList.Add(cust);
            homeForm.submitCustForm(newCust);
        }

        /// <summary>
        /// Find customer takes a user input and filters the shown customers based on matched 
        /// first or last name
        /// </summary>
        /// <param name="userInput"></param>
        /// <param name="custList"></param>
        /// <param name="formReference"></param>
        public static void findCustomer(String userInput, ListBox custList, Form1 formReference)
        {
            String[] splitInput = userInput.ToUpper().Split(' ');
            ArrayList searchList = new ArrayList();
            for (int i = 0; i < custAList.Count; i++)
            {
                /// Switch case that filters the customer list based on matching parameters
                /// if more than 2 words or less than 1 word is entered into the search bar
                /// it will revert to the full list of customers
                switch (splitInput.Length)
                {
                    default:
                        MessageBox.Show("Please search using first and/or last name only", "Search Error");
                        break;
                    case 1:
                        if (splitInput[0] == ((Customer)custAList[i]).FirstName.ToUpper() || splitInput[0] == ((Customer)custAList[i]).LastName.ToUpper())
                        {
                            searchList.Add(custAList[i]);
                        }
                        else
                        {
                            formReference.updateList();
                        }
                        break;
                    case 2:
                        if (splitInput[0] == ((Customer)custAList[i]).FirstName.ToUpper() || splitInput[1] == ((Customer)custAList[i]).LastName.ToUpper())
                        {
                            searchList.Add(custAList[i]);
                        }
                        break;
                }
            }
            /// clears the current list box of the entire customer list so the filtered
            /// list can be shown rather than appending to the end of the existing list
            if (searchList.Count > 0) custList.Items.Clear();
            for (int i = 0; i < searchList.Count; i++)
            {
                custList.Items.Add(((Customer)searchList[i]).CustomerID + " " + ((Customer)searchList[i]).FirstName + " " + ((Customer)searchList[i]).LastName);
            }
        }
        /// <summary>
        /// The View Customer method opens the form with the selected customers information
        /// </summary>
        /// <param name="cust"></param>
        public static void viewCustomer(Customer cust)
        {
            viewCustomer custView = new viewCustomer(cust);
            custView.ShowDialog();
        }


        /// <summary>
        ///  Opens the Create Account Form
        /// </summary>
        /// <param name="cust"></param>
        public static void openAccountForm(Customer cust)
        {
            openAccount openAcc = new openAccount(cust);
            openAcc.ShowDialog();
        }

        /// <summary>
        /// Opens the edit customer form
        /// </summary>
        /// <param name="cust"></param>
        public static void editCust(Customer cust)
        {
            editCust editForm = new editCust(cust);
            editForm.ShowDialog();
        }
        /// <summary>
        /// Saves the customer changes made in the edit customer form when submitted
        /// </summary>
        /// <param name="original"></param>
        /// <param name="editCust"></param>
        public static void submitEdit(Customer original, Customer editCust)
        {
            for (int i = 0; i < custAList.Count; i++)
            {
                if (((Customer)custAList[i]).FirstName == original.FirstName && ((Customer)custAList[i]).LastName == original.LastName)
                {
                    custAList[i] = editCust;
                }
            }
        }

        /// <summary>
        /// Opens the delete customer form
        /// </summary>
        /// <param name="cust"></param>

        public static void deleteCustomer(Customer cust)
        {
            deleteCust deleteForm = new deleteCust(cust);
            deleteForm.ShowDialog();
        }
        /// <summary>
        /// Deletes the selected customer once it has been confirmed by the user
        /// </summary>
        /// <param name="cust"></param>
        public static void submitDelete(Customer cust)
        {
            custAList.Remove(cust);
            homeForm.updateList();
        }

        /// <summary>
        /// Opens the Account Transfer Form
        /// </summary>
        /// <param name="cust"></param>
        /// <param name="viewCustForm"></param>
        public static void accountTransfer(Customer cust, viewCustomer viewCustForm)
        {
            transForm transferForm = new transForm(cust);
            transferForm.ShowDialog();
        }

        /// <summary>
        /// Stores the customer list and id count to a serialized binary file
        /// </summary>
        public static void serialize_and_close()
        {
            DataSerializer ds = new DataSerializer();
            Console.WriteLine(custAList);
            Console.WriteLine(Customer.customerIDCounter);
            ds.BinarySerialize(custAList, "customerList.txt");
            ds.BinarySerialize(Customer.customerIDCounter, "idCounter.txt");
        }

        /// <summary>
        /// Retrieves Customer List and ID count from Serialized Binary Files
        /// </summary>
        public static void deserialize_and_load()
        {
            DataSerializer ds = new DataSerializer();
            ArrayList loadedList = (ArrayList)ds.BinaryDeserialize("customerList.txt");
            if (loadedList != null) custAList = loadedList;
            object loadedCount = ds.BinaryDeserialize("idCounter.txt");
            Console.WriteLine(loadedCount);
            if (loadedCount != null) Customer.customerIDCounter = (int)loadedCount;
        }
    }

    /// <summary>
    /// Data Serializer class with methods to store and retrieve data from serialized files.
    /// </summary>
    class DataSerializer
    {
        /// <summary>
        /// Checks to see if file exists, if true it deletes and replaces the file, if false creates the file.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="filePath"></param>
        public void BinarySerialize(object data, string filePath)
        {
            FileStream filestream;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(filePath)) File.Delete(filePath);
            filestream = File.Create(filePath);
            bf.Serialize(filestream, data);
            filestream.Close();
        }

        /// <summary>
        /// Retrieves data from serialized binary file and returns it as an object
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public object BinaryDeserialize(string filePath)
        {
            object obj = null;
            FileStream fileStream;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(filePath))
            {
                fileStream = File.OpenRead(filePath);
                obj = bf.Deserialize(fileStream);
                fileStream.Close();
            }
            return obj;
        }
    }
}
