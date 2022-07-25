using AccountsRefactored.Interfaces;

namespace AccountsRefactored.AccountTypes
{
    public class RegularSavingAccount : ISavingAccountWithWithdraw
    {
        public decimal Balance { get; set; }

        public bool Withdraw(decimal amount)
        {
            var moneyAfterWithdrawal = Balance - amount;
            if (moneyAfterWithdrawal >= 1000)
            {
                Balance = moneyAfterWithdrawal;
                return true;
            }

            return false;
        }
    }
}