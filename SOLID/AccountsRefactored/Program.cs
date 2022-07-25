using AccountsRefactored.AccountTypes;
using AccountsRefactored.Interfaces;

namespace AccountsRefactored
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ISavingAccountWithWithdraw account1 = new RegularSavingAccount();
            ISavingAccountWithWithdraw account2 = new SalarySavingAccount();
            ISavingAccountWithoutWithdraw account3 = new FixDepositSavingAccount();

            AccountManager.WithdrawFrom(account1, 100);
            AccountManager.WithdrawFrom(account2, 200);
            AccountManager.WithdrawFrom(account3, 300); //error at build time
        }
    }
}