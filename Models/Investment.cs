using System;
using System.Windows.Forms;

namespace Assmt_2___GUI_Debugging_and_Testing.Models
{
    /// <summary>
    /// Investment class that inherits from Account
    /// </summary>
    [Serializable]
    public class Investment : Account
    {
        /// <summary>
        /// Flat interest rate as per assignment requirements
        /// </summary>
        public float interestRate = 0.04f;
        /// <summary>
        /// Default Investment Account constructor
        /// </summary>
        public Investment()
        {

        }
        public Investment(Customer owner)
        {
            this.Owner = owner;
        }
        /// <summary>
        /// Investment account constructor that takes a starting balance
        /// </summary>
        /// <param name="balance"></param>
        public Investment(float balance)
        {
            withdrawFailFee = 10.0f;
            this.balance = balance;
        }
        public Investment(Customer owner, float balance)
        {
            withdrawFailFee = 10.0f;
            this.balance = balance;
            this.Owner = owner;
        }
        /// <summary>
        /// Method to calculate and add the interest to the balance
        /// </summary>
        /// <example>
        /// float balance = 100f;
        /// float interest = 0.04f
        /// calcInterest();
        /// The resulting balance would then be 104f
        /// </example>
        public void calcInterest()
        {
            float interestGain = balance * interestRate;
            balance += interestGain;
            Console.WriteLine("interest percentage %" + (interestRate * 100).ToString());
            MessageBox.Show("Interest %" + (interestRate * 100) + " of $" + interestGain.ToString() + " has been added to the account for a total balance of $" + balance.ToString(), "Investment Interest");
        }
    }

}
