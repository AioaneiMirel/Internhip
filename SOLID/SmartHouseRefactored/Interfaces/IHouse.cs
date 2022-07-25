namespace SmartHouseRefactored.Interfaces
{
    public interface IHouse
    {
        void EnableFullLockDown();
        void LockMainDoor();
        string UnlockMainDoor(decimal securityCode);
        string GetHouseHistory();
    }
}