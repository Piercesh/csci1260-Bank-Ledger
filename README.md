Sid Pierce
CSCI-1260-002 Object Oriented Programming
Assignment 1 Bank Ledger
In this code I have made it to where you are capable of withdrawing and depositing the money you put in.
There are three classes that are made. The Transaction class, the Account class, and the Ledger class.
#Transaction
The Transaction class didn't take too long since I needed to just put in id, kind, and amount in private and also make a public version with {get}
There is also the IsDeposit() and the Describe() that should be in the transaction class.
IsDeposit() what will help make the deposit be possible and it will be considered either true or false.
Describe() will show you what will be the id, kind and amount that will be on the code.
#Account
The next class is the Account class which did take a bit of time, but I did make sure everything was set up correctly.
This class will have owner and balance. They should be capable of getting the owners name and should show the balance of the money.
In this class It should be capable of showing the balance and will add and subtract what you have put in.
The ToString() Should be capable of showing the owner and balance once you have run the code.
#Ledger
For the last class that needed to be put in, there is Ledger.
Ledger will need to have Account, list<Transaction>, and nextId.
I then put in the int Count so that it will remember the numbers that were put into the transaction.
a public ledger would have to be made so it can make the account, so that will be capable of putting in the Id, show the list, and the money of the account.
Next things that needed to be put in are a public Withdraw and Deposit.
Withdraw will take money away, while Deposit will add in money.
If you try to go and try to withdraw too much money then it will not work.
Ledger was the class that took me the longest to get done.
#Main
And the last one was Main itself. It needed to some code that was connected to Ledger for it to work.
This should show the person's name and the balance that will be the total from the withdraw and deposit.
When running the code, it will show the person's name and the total balance they have.
It will also show the withdraw and deposit that is in the code.
This took me a few days to make, but I did get completed and it should run the code just fine.
