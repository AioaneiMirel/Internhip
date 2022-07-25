using CarsFilterRefactored.Enums;
using CarsFilterRefactored.Interfaces;

namespace CarsFilterRefactored.Conditions
{
    public class CustomCondition : ICondition<Car>
    {
        private readonly CarType _carType;
        private readonly Color _color;

        public CustomCondition(CarType carType, Color color)
        {
            _carType = carType;
            _color = color;
        }

        public bool IsSatisfied(Car item)
        {
            return _carType == item.Type && _color == item.Color;
        }
    }
}