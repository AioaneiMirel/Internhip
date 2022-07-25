using System;

namespace Accounts.AccountTypes
{
    public class FixDepositSavingAccount : SavingAccount
    {
        public override bool Withdraw(decimal amount)
        {
            throw new Exception("Not supported by this account type");
        }
    }
}