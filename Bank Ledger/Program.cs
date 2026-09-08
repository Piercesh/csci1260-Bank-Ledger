namespace Bank_Ledger
{
    class Program
    {
       static void Main(string[] args)
       {
            Account account = new Account("Ada Lovelace", 500.00);
            Ledger ledger = new Ledger(account);

            ledger.Deposit(500.00);
            ledger.Withdraw(200.00);
            ledger.Withdraw(50.00);

            ledger.PrintHistory();
        } 
    }
}


