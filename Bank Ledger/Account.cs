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

        public string Owner
        {
            get { return owner; }
        }

        public double Balance
        {
            get { return balance; }
        }

        public Account (string owner, double startingBalance = 0)
        {
            this.owner = owner;
            this.balance = startingBalance;
        }

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

        public override string ToString()
        {
            return $"{Owner}: ${Balance:F2}";
        }
    }
}
