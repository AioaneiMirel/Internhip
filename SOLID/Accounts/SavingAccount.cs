namespace Accounts
{
    public abstract class SavingAccount
    {
        public decimal Balance { get; set; }
        public abstract bool Withdraw(decimal amount);
    }
}