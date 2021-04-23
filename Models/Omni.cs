using System;

namespace Assmt_2___GUI_Debugging_and_Testing.Models
{
    /// <summary>
    /// Omni account class that inherits from the Investment class
    /// </summary>
    [Serializable]
    public class Omni : Investment
    {

        public Omni(Customer owner)
        {
            this.Owner = owner;
        }
        /// <summary>
        /// Omni Constructor that takes a starting balance
        /// </summary>
        /// <param name="balance"></param>
        public Omni(float balance)
        {
            this.balance = balance;
            overdraft = 1000.0f;
        }

        public Omni(Customer owner, float balance)
        {
            this.Owner = owner;
            this.balance = balance;
        }
        /// <summary>
        /// Omni Constructor that takes a starting balance and overdraft limit
        /// Overdraft is redundant for this assignment
        /// </summary>
        /// <param name="balance"></param>
        /// <param name="overdraft"></param>
        public Omni(float balance, float overdraft)
        {
            this.balance = balance;
            this.overdraft = overdraft;
            withdrawFailFee = 10.0f;
        }

        public Omni(Customer owner, float balance, float overdraft)
        {
            this.Owner = Owner;
            this.balance = balance;
            this.overdraft = overdraft;
            withdrawFailFee = 10.0f;
        }
    }
}
