using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Ledger
{
    public class Transaction
    {
        /// <summary>
        /// This is where the id, kind and amount are private.
        /// </summary>
        private int id;
        private string kind;
        private double amount;

        public int Id { get; }
        public string Kind { get; }
        public double Amount { get; }

        public Transaction(int id, string kind, double amount)
        {
            this.id = id;
            this.kind = kind;
            this.amount = amount;
        }
        public bool IsDeposit()
        {
            if (kind == "deposit")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Describe()
        {          
            return ($"Transaction ID: {id}, Kind: {kind}, Amount: {amount}");
        }
    }
}
