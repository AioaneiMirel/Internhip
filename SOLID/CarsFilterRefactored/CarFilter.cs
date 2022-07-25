using System.Collections.Generic;
using System.Linq;
using CarsFilterRefactored.Interfaces;

namespace CarsFilterRefactored
{
    public class CarFilter
    {
        public List<Car> For(IEnumerable<Car> cars, ICondition<Car> condition)
        {
            return cars.Where(m => condition.IsSatisfied(m)).ToList();
        }
    }
}