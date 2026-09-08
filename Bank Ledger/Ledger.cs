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

        public int Count { get; }

        public Ledger(Account account)
        {
            this.account = account;
            this.history = new List<Transaction>();
            this.nextId = 1;
        }

        public bool Deposit(double amount)
        {
            if (!account.Deposit(amount))
                return false;

            history.Add(new Transaction(nextId++, "deposit", amount));
            return true;
        }

        public bool Withdraw(double amount)
        {
            if (!account.Withdraw(amount))
                return false;
            history.Add(new Transaction(nextId++, "withdrawal", amount));
            return true;
        }

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
