namespace AccountsRefactored.Interfaces
{
    public interface ISavingAccountWithWithdraw : ISavingAccount
    {
        bool Withdraw(decimal amount);
    }
}