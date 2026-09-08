using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Ledger
{
    public class Ledger
    {
        private Account account;
        private List<Transaction> history;
        private int nextId;
        /// <summary>
        /// This is going to make it to where what you have either withdraw or deposit will be shown in the history of the ledger.
        /// </summary>
        public int Count
        {
            get { return history.Count; }
        }
        /// <summary>
        /// This will show the id, it will show what type of transaction your doing,
        /// and it will show the amount of money that is being put into the ledger.
        /// </summary>
        /// <param name="account"></param>
        public Ledger(Account account)
        {
            this.account = account;
            this.history = new List<Transaction>();
            this.nextId = 1;
        }
        /// <summary>
        /// This is going to make sure it deposits the exact amount you put in.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public bool Deposit(double amount)
        {
            if (!account.Deposit(amount))
                return false;

            history.Add(new Transaction(nextId++, "deposit", amount));
            return true;
        }
        /// <summary>
        /// this is going to withdraw the amount of money you have put in.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public bool Withdraw(double amount)
        {
            if (!account.Withdraw(amount))
                return false;
            history.Add(new Transaction(nextId++, "withdrawal", amount));
            return true;
        }
        /// <summary>
        /// In this class, this will show the owners name and the account balance. 
        /// It will also show the id, the kind, and will show the ammount of money that has been put into the ledger.
        /// </summary>
        public void PrintHistory()
        {
            Console.WriteLine($"Account owner: {account.Owner}");
            Console.WriteLine($"Current balance: ${account.Balance:F2}");
            Console.WriteLine("\nTransaction history:");
            foreach (Transaction transaction in history)
            {
                Console.WriteLine($"ID: {transaction.Id}, Type: {transaction.Kind}, Amount: ${transaction.Amount:F2}");
            }
        }
    }
}
