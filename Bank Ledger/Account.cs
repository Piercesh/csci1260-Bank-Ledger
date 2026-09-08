using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Ledger
{
    public class Account
    {
        private string owner;
        private double balance;
        /// <summary>
        /// This will get the name of the owner.
        /// </summary>
        public string Owner
        {
            get { return owner; }
        }
        /// <summary>
        /// This will get the balance of the account.
        /// </summary>
        public double Balance
        {
            get { return balance; }
        }
        /// <summary>
        /// This is going to help get the owners name and it will show the balance of the money.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="startingBalance"></param>
        public Account (string owner, double startingBalance = 0)
        {
            this.owner = owner;
            this.balance = startingBalance;
        }
        /// <summary>
        /// Deposit is going to add in more money to the balance that you have put in.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public bool Deposit(double amount)
        {
            if (amount <= 0)
            {
                return false;
            }
            else
            {
                balance += amount;
                return true;
            }
        }
        /// <summary>
        /// With Withdraw, this will take away the amount of money that is in the balance you have put in.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public bool Withdraw(double amount)
        {
            if (amount <= 0 || amount > balance)
            {
                return false;
            }
            else
            {
                balance -= amount;
                return true;
            }
        }
        /// <summary>
        /// This is where it will return the name of the owner and the balance of the account.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Owner}: ${Balance:F2}";
        }
    }
}
