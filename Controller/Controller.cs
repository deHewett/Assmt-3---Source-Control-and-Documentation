using Assmt_2___GUI_Debugging_and_Testing.View_Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assmt_2___GUI_Debugging_and_Testing.Controller
{
    public static class Controller
    {
        public static ArrayList custAList = new ArrayList();
        public static Form1 homeForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        public static editCust editForm;

        // 
        // GET: /Controller/addCustomer/ 

        public static void addCust()
        {
            createCust newCust = new createCust();
            newCust.ShowDialog();
        }

        // Takes the customer objectas
        public static void submitCust(Customer cust)
        {
            custAList.Add(cust);
            homeForm.submitCustForm(cust);
        }


        // 
        // GET: /Controller/findCustomer/ 

        public static void findCustomer(String userInput)
        {
            String[] splitInput = userInput.Split(' ');
            for (int i = 0; i < custAList.Count; i++)
            {
                if (((Customer)custAList[i]).FirstName == splitInput[0] && ((Customer)custAList[i]).LastName == splitInput[1])
                {
                    Customer temp = (Customer)custAList[i];
                    viewCustomer custView = new viewCustomer((Customer)custAList[i]);
                    custView.ShowDialog();
                }
            }
        }

        public static void deposit(Customer cust, float amount)
        {
            for (int i = 0; i < custAList.Count; i++)
            {
                if (((Customer)custAList[i]).FirstName == cust.FirstName && ((Customer)custAList[i]).LastName == cust.LastName)
                {
                    Customer tempCust = (Customer)custAList[i];
                    tempCust.customerAccount.deposit(amount);
                    custAList[i] = tempCust;
                }
            }
        }

        public static string withdraw(Customer cust, float amount)
        {
            for (int i = 0; i < custAList.Count; i++)
            {
                if (((Customer)custAList[i]).FirstName == cust.FirstName && ((Customer)custAList[i]).LastName == cust.LastName)
                {
                    Customer tempCust = (Customer)custAList[i];
                    
                    custAList[i] = tempCust;
                    return tempCust.customerAccount.withdraw(amount);
                }
            }
            return cust.customerAccount.balance.ToString();
        }


        // 
        // GET: /Controller/editCustomer/ 

        public static void editCust(Customer cust)
        {
            editCust editForm = new editCust(cust);
            editForm.ShowDialog();
        }
        public static void submitEdit(Customer original, Customer editCust)
        {
            for (int i=0; i<custAList.Count; i++)
            {
                    if (((Customer)custAList[i]).FirstName == original.FirstName && ((Customer)custAList[i]).LastName == original.LastName)
                    {
                        custAList[i] = editCust;
                    }
            }
        }
        // 
        // GET: /Controller/deleteCustomer/ 

        public static void deleteCustomer(Customer cust)
        {
            deleteCust deleteForm = new deleteCust(cust);
            deleteForm.ShowDialog();
        }

        public static void submitDelete(Customer cust)
        {
            custAList.Remove(cust);
            homeForm.updateList();
        }

        public static void accountTransfer(Customer cust)
        {
            transForm transferForm = new transForm(cust);
            transferForm.ShowDialog();
        }


    }
}
