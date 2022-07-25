using Microsoft.AspNetCore.Mvc;
using SmartHouseRefactored.Interfaces;

namespace SmartHouseRefactored.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccessibilityController : ControllerBase
    {
        private readonly IHouse _house;

        public AccessibilityController(IHouse house)
        {
            _house = house;
        }

        [HttpGet("GetHouseHistory")]
        public string GetHouseHistory()
        {
            return _house.GetHouseHistory();
        }

        [HttpPost("LockDownTheHouse")]
        public void LockDownTheHouse()
        {
            _house.EnableFullLockDown();
        }

        [HttpPost("LockMainDoor")]
        public void LockMainDoor()
        {
            _house.LockMainDoor();
        }

        [HttpPost("UnlockMainDoor")]
        public string UnlockMainDoor(decimal securityCode)
        {
            return _house.UnlockMainDoor(securityCode);
        }
    }
}