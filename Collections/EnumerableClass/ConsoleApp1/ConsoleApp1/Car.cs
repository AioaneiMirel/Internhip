﻿using System;

namespace ConsoleApp1
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Car data: {Id}   {Name}";
        }
    }
}
