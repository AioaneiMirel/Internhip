using Accounts.AccountTypes;

namespace Accounts
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SavingAccount account1 = new RegularSavingAccount();
            SavingAccount account2 = new SalarySavingAccount();
            SavingAccount account3 = new FixDepositSavingAccount();

            AccountManager.WithdrawFrom(account1, 100);
            AccountManager.WithdrawFrom(account2, 200);
            AccountManager.WithdrawFrom(account3, 300);
        }
    }
}