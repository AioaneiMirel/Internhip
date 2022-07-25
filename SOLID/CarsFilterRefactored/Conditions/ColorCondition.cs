using CarsFilterRefactored.Enums;
using CarsFilterRefactored.Interfaces;

namespace CarsFilterRefactored.Conditions
{
    public class ColorCondition : ICondition<Car>
    {
        private readonly Color _color;

        public ColorCondition(Color color)
        {
            _color = color;
        }

        public bool IsSatisfied(Car item)
        {
            return item.Color == _color;
        }
    }
}