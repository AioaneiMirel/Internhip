using System.Text;
using Microsoft.AspNetCore.Mvc;
using Play.Strategies;

namespace Play.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumbersController : ControllerBase
    {
        public IEnumerable<IStrategy> Strategies { get; set; }

        public NumbersController(IEnumerable<IStrategy> strategies)
        {
            Strategies = strategies;
        }


        [HttpGet]
        public string GetNumbers()
        {
            var sb = new StringBuilder();
            var numbers = Enumerable.Range(0, 100).Select(x => new Random().Next(-100, 100));

            foreach (var number in numbers)
            {
                var strategies = Strategies.Where(x => x.IsValid(number));
                foreach (var strategy in strategies)
                {
                    strategy.Add(number);
                }
            }

            foreach (var strategy in Strategies)
            {
                sb.AppendLine(strategy.Name + ":");

                foreach (var number in strategy.GetNumbers())
                {
                    sb.Append(" " + number);
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
