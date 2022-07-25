using SmartHouseRefactored.Interfaces;

namespace SmartHouseRefactored.Implementations
{
    public class House : IHouse
    {
        private readonly IInformationService _informationService;
        private readonly ISecurity _security;

        public House(ISecurity security, IInformationService informationService)
        {
            _security = security;
            _informationService = informationService;
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
            return _security.UnlockFrontDoor(securityCode);
        }

        public string GetHouseHistory()
        {
            return _informationService.GetInformation();
        }
    }
}