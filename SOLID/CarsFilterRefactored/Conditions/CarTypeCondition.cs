using CarsFilterRefactored.Enums;
using CarsFilterRefactored.Interfaces;

namespace CarsFilterRefactored.Conditions
{
    public class CarTypeCondition : ICondition<Car>
    {
        private readonly CarType _type;

        public CarTypeCondition(CarType type)
        {
            _type = type;
        }

        public bool IsSatisfied(Car item)
        {
            return item.Type == _type;
        }
    }
}