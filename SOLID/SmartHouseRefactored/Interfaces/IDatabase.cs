namespace SmartHouseRefactored.Interfaces
{
    public interface IDatabase
    {
        decimal GetAccessCode();
        string GetStatus();
        void Save(string performedAction);
    }
}