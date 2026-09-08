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
        /// <summary>
        /// This will get the id, kind and amount of the transaction and show the name and the amount of money.
        /// </summary>
        public int Id
        {
            get { return id; }
        }
        public string Kind
        {
            get { return kind; }
        }
        public double Amount
        {
            get { return amount; }
        }
        /// <summary>
        /// This will make it capable of creating a transaction with an id, kind and amount.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="kind"></param>
        /// <param name="amount"></param>
        public Transaction(int id, string kind, double amount)
        {
            this.id = id;
            this.kind = kind;
            this.amount = amount;
        }
        /// <summary>
        /// This is how the deposit will happen and it will make the deposit is either true or false.
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// This is what will show the id, kind and amount when you run the code
        /// </summary>
        /// <returns></returns>
        public string Describe()
        {          
            return ($"Transaction ID: {id}, Kind: {kind}, Amount: {amount}");
        }
    }
}
