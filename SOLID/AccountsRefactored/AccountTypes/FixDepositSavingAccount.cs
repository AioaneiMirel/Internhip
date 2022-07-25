using AccountsRefactored.Interfaces;

namespace AccountsRefactored.AccountTypes
{
    public class FixDepositSavingAccount : ISavingAccountWithoutWithdraw
    {
        public decimal Balance { get; set; }
    }
}