using AccountsRefactored.Interfaces;

namespace AccountsRefactored.AccountTypes
{
    public class SalarySavingAccount : ISavingAccountWithWithdraw
    {
        public decimal Balance { get; set; }

        public bool Withdraw(decimal amount)
        {
            var moneyAfterWithdraw = Balance - amount;
            if (moneyAfterWithdraw >= 0)
            {
                Balance = moneyAfterWithdraw;
                return true;
            }

            return false;
        }
    }
}