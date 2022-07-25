using SmartHouseRefactored.Interfaces;

namespace SmartHouseRefactored.Implementations
{
    public class Security : ISecurity
    {
        private readonly IDatabase _database;

        public Security(IDatabase database)
        {
            _database = database;
        }

        public void FullLockDown()
        {
            const string message = "Full LockDown enabled!";

            _database.Save(message);
        }

        public void LockFrontDoor()
        {
            const string message = "Front door locked";

            _database.Save(message);
        }

        public string UnlockFrontDoor(decimal accessCode)
        {
            const string validMessage = "Access granted!";
            const string invalidMessage = "Access code Invalid! Access denied!";

            if (accessCode != _database.GetAccessCode())
            {
                _database.Save(invalidMessage);

                return invalidMessage;
            }

            _database.Save(validMessage);

            return validMessage;
        }
    }
}