namespace Accounts
{
    public class AccountManager
    {
        public static bool WithdrawFrom(SavingAccount account, decimal amount)
        {
            return account.Withdraw(amount);
        }
    }
}