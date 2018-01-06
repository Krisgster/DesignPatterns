using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Create_Builder
{
    public class CarBuilder : ICarBuilder
    {
        private Car _car = new Car();
        public ICarBuilder BuildMake(string make)
        {
            _car.Make = make;
            return this;
        }
        public ICarBuilder BuildModel(string model)
        {
            _car.Model = model;
            return this;
        }
        public ICarBuilder BuildYear(int year)
        {
            _car.Year = year;
            return this;
        }
        public ICarBuilder BuildDoors(int doors)
        {
            _car.Doors = doors;
            return this;
        }
        public ICarBuilder BuildColor(string color)
        {
            _car.Color = color;
            return this;
        }
        public ICarBuilder BuildOriginal(string original)
        {
            _car.Make = original;
            return this;
        }
        public Car Build()
        {
            return _car;
        }
    }
}
