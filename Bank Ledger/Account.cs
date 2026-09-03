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

        public string Owner { get; }

        public double Balance { get;}

        public Account (string owner, double startingBalance)
        {
            this.owner = owner;
            this.balance = startingBalance;
        }
    }
}
