namespace MyApp.OOP.HomeworkLecture7
{
    public class BankAccount
    {
        public string AccountNumber;
        public decimal Balance;

        public BankAccount(string accountNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public void Deposit(decimal depositAmount)
        {
            Balance += depositAmount;
        }

        public void Withdraw(decimal withdrawalAmount)
        {
            if (Balance - withdrawalAmount < 0)
                throw new InsufficientFundsException($"\nInsufficiant Funds. \nWithdrawl Amount: {withdrawalAmount}\nAccount Ballance: {Balance}");
            Balance -= withdrawalAmount;
        }

        class InsufficientFundsException : Exception
        {
            public InsufficientFundsException() { }

            public InsufficientFundsException(string message) : base(message) { }
        }
    }
}
