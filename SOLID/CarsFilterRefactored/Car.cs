using System;
using System.Collections.Generic;
using System.Text;
using CarsFilterRefactored.Enums;

namespace CarsFilterRefactored
{
    public class Car
    {
        public string Name { get; set; }
        public CarType Type { get; set; }
        public Color Color { get; set; }
    }
}
