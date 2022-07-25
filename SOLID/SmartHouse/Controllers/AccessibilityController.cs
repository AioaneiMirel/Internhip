using Microsoft.AspNetCore.Mvc;

namespace SmartHouse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccessibilityController : ControllerBase
    {
        [HttpGet("GetHouseHistory")]
        public string GetHouseHistory()
        {
            var house = new House();
            return house.GetHouseHistory();
        }

        [HttpPost("LockDownTheHouse")]
        public void LockDownTheHouse()
        {
            var house = new House();

            house.EnableFullLockDown();
        }

        [HttpPost("LockMainDoor")]
        public void LockMainDoor()
        {
            var house = new House();

            house.LockMainDoor();
        }

        [HttpPost("UnlockMainDoor")]
        public string UnlockMainDoor(decimal securityCode)
        {
            var house = new House();

            return house.UnlockMainDoor(securityCode);
        }
    }
}