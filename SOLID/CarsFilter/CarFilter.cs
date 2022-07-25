using System.Collections.Generic;
using System.Linq;
using CarsFilter.Enums;

namespace CarsFilter
{
    public class CarFilter
    {
        public List<Car> FilterByType(IEnumerable<Car> cars, CarType type) =>
            cars.Where(c => c.Type == type).ToList();
    }
}
