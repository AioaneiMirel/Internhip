namespace SmartHouse
{
    public class House
    {
        private readonly Security _security;
        private readonly InformationService _informationService;

        public House()
        {
            _security = new Security();
            var fileDatabase = new FileDatabase();
            _informationService = new InformationService(fileDatabase);
        }

        public void EnableFullLockDown()
        {
            _security.FullLockDown();
        }

        public void LockMainDoor()
        {
            _security.LockFrontDoor();
        }

        public string UnlockMainDoor(decimal securityCode)
        {
            var security = new Security();

            return security.UnlockFrontDoor(securityCode);
        }

        public string GetHouseHistory()
        {
            return _informationService.GetInformation();
        }
    }
}