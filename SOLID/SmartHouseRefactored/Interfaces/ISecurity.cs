namespace SmartHouseRefactored.Interfaces
{
    public interface ISecurity
    {
        void FullLockDown();
        void LockFrontDoor();
        string UnlockFrontDoor(decimal accessCode);
    }
}