namespace SmartHouse
{
    public class Security
    {
        public void FullLockDown()
        {
            const string message = "Full LockDown enabled!";

            var db = new FileDatabase();
            db.Save(message);
        }

        public void LockFrontDoor()
        {
            const string message = "Front door locked";

            var db = new FileDatabase();
            db.Save(message);
        }

        public string UnlockFrontDoor(decimal accessCode)
        {
            const string validMessage = "Access granted!";
            const string invalidMessage = "Access code Invalid! Access denied!";

            var db = new FileDatabase();

            if (accessCode != db.GetAccessCode())
            {
                db.Save(invalidMessage);
                return invalidMessage;
            }

            db.Save(validMessage);

            return validMessage;
        }
    }
}