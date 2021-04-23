using System;
using System.Windows.Forms;

namespace Assmt_2___GUI_Debugging_and_Testing.Models
{
    /// <summary>
    /// Everyday Account class labelled simply Account
    /// Contains all main functions of a bank account including: Deposit, Withdraw
    /// </summary>
    [Serializable]
    public class Account
    {
        /// <summary>
        /// Variable declaration
        /// </summary>
        static int idCounter = 0;
        public int accountID { get; set; }
        public float balance { get; set; }
        public float overdraft { get; set; }
        public float withdrawFailFee { get; set; }
        public Customer Owner { get; set; }

        public string LastTransaction;
        /// <summary>
        /// default account constructor that initializes necessary variables
        /// </summary>
        public Account()
        {
            accountID = idCounter;
            balance = 0.0f;
            overdraft = 0.0f;
            withdrawFailFee = 0.0f;
            idCounter++;
        }

        /// <summary>
        /// Account constructor that takes reference to the Customer object it belongs to
        /// </summary>
        /// <param name="Owner"></param>
        public Account(Customer Owner)
        {
            this.Owner = Owner;
            accountID = idCounter + 1;
            balance = 0.0f;
            overdraft = 0.0f;
            withdrawFailFee = 0.0f;
            idCounter++;
        }
        /// <summary>
        /// Account constructor that takes reference to the Customer object it belongs to and a starting balance
        /// </summary>
        /// <param name="Owner"></param>
        /// <param name="balance"></param>
        public Account(Customer Owner, float balance)
        {
            this.Owner = Owner;
            accountID = idCounter + 1;
            this.balance = balance;
            overdraft = 0.0f;
            withdrawFailFee = 0.0f;
            idCounter++;

        }
        /// <summary>
        /// The deposit function takes the depAmount args and adds it to the balance. This is relayed to the user through a message box
        /// </summary>
        /// <param name="depAmount"></param>
        public void deposit(float depAmount)
        {
            balance += depAmount;
            MessageBox.Show(depAmount.ToString() + " has been deposited successfully", "Deposit Success");
    
        }
        /// <summary>
        /// The withdraw function takes the withdrawAmount args and deducts it from the balance. This is relayed to the user through a message box
        /// </summary>
        /// <param name="withdrawAmount"></param>
        public void withdraw(float withdrawAmount)
        {
            try
            {
                if (balance + overdraft >= withdrawAmount)
                {
                    balance -= withdrawAmount;
                    if (balance < 0)
                    {
                        overdraft += balance;
                        balance = 0;
                    }
                    MessageBox.Show(withdrawAmount.ToString() + " has been withdrawn successfully", "Withdrawal Success");

                }
                else
                {
                    /// Customers with the staff attribute recieve 50% off any fees as per assignment requirements
                    if (Owner.staff)
                    {
                        balance -= (withdrawFailFee / 2);
                        MessageBox.Show("Insufficient funds available to withdraw, a fee of $" + (withdrawFailFee / 2).ToString() + " has been deducted from the account", "Failed Withdrawal");
                        /// throws an exception if the withdrawal fails and displays it to the user
                        throw new failedWithdrawalException(LastTransaction);
                    }
                    else
                    {
                        balance -= withdrawFailFee;
                        MessageBox.Show("Insufficient funds available to withdraw, a fee of $" + withdrawFailFee.ToString() + " has been deducted from the account", "Failed Withdrawal");
                        /// throws an exception if the withdrawal fails and displays it to the user
                        throw new failedWithdrawalException(LastTransaction);
                    }

                }
            }
            catch (failedWithdrawalException e)
            {
                DialogResult dialogResult = MessageBox.Show(e.Message);
                MessageBox.Show(balance.ToString(), "Failed Withdrawal");
            }
        }
        /// <summary>
        /// Everyday accounts accrue no interest. This is displayed to the user when called
        /// </summary>
        public void calcInterest()
        {
            MessageBox.Show("Everyday Accounts do not accrue interest", "Everyday Interest");
        }
    }
    /// <summary>
    /// incomplete exception class that is thrown if a withdrawal fails
    /// </summary>
    public class failedWithdrawalException : Exception
    {
        public failedWithdrawalException()
        {

        }

        public failedWithdrawalException(string message) : base(message)
        {

        }
    }
}
