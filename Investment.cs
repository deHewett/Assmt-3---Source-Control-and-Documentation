using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Name space is as follows as the project continues on from the previous assignment.
namespace Assmt_2___GUI_Debugging_and_Testing.Models
{
    public class Investment : Account
    {
        public float interestRate = 0.02f;
        public Investment() { }
        public Investment(Customer Owner)
        {
            withdrawFailFee = 10.0f;
            this.Owner = Owner;
        }
        public Investment(Customer Owner, float balance)
        {
            withdrawFailFee = 10.0f;
            this.balance = balance;
            this.Owner = Owner;
        }

        public string scalingInterest()
        {
            float interestGain = balance * interestRate;
            balance += interestGain;
            LastTransaction = "Interest %" + interestRate + " of $" + interestGain.ToString() + " has been added to the account for a total balance of $" + balance.ToString();
            interestRate += 0.005f;
            return LastTransaction;
        }
    }

}
