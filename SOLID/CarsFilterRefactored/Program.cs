using System;
using System.Collections.Generic;
using CarsFilterRefactored.Conditions;
using CarsFilterRefactored.Enums;

namespace CarsFilterRefactored
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Car {Name = "Tesla model 3", Type = CarType.Sedan, Color = Color.Red},
                new Car {Name = "Jaguar F-Type", Type = CarType.Coupe, Color = Color.Blue},
                new Car {Name = "Aston Martin Vantage", Type = CarType.Coupe, Color = Color.Red},
                new Car {Name = "Cybertruck", Type = CarType.Truck, Color = Color.Gray},
                new Car {Name = "Mercedes Benz A Class", Type = CarType.Sedan, Color = Color.Red}
            };

            var filter = new CarFilter();

            //var sedanCars = filter.FilterByType(cars, CarType.Sedan);

            var sedanCars = filter.For(cars, new CarTypeCondition(CarType.Sedan));
            var redCars = filter.For(cars, new ColorCondition(Color.Red));
            var redSedanCars = filter.For(cars, new CustomCondition(CarType.Sedan, Color.Red));
            

            Console.WriteLine($"All {nameof(sedanCars)}");
            foreach (var car in redCars)
            {
                Console.WriteLine($"Name: {car.Name}, Type: {car.Type}, Color: {car.Color}");
            }
        }
    }
}