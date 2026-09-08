namespace Bank_Ledger
{
    class Program
    {
       static void Main(string[] args)
       {
            ///Here is where it will show the persons name and the amount of money they have.
            Account account = new Account("Ada Lovelace", 500.00);
            Ledger ledger = new Ledger(account);
            ///Deposit will add to the amount of money the person has and withdraw will take away from the amount of money the person has.
            ledger.Deposit(325.25);
            ledger.Withdraw(125.50);

            ///This will make it to where it will show the history of the transactions that have been made.
            ledger.PrintHistory();
        } 
    }
}


