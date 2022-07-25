using SmartHouseRefactored.Interfaces;

namespace SmartHouseRefactored.Implementations
{
    public class InformationService : IInformationService
    {
        private readonly IDatabase _database;

        public InformationService(IDatabase database)
        {
            _database = database;
        }

        public string GetInformation()
        {
            return _database.GetStatus();
        }
    }
}