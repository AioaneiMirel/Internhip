using AccountsRefactored.Interfaces;

namespace AccountsRefactored
{
    public class AccountManager
    {
        public static bool WithdrawFrom(ISavingAccountWithWithdraw account, decimal amount)
        {
            return account.Withdraw(amount);
        }
    }
}