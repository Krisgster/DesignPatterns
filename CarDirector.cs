using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Create_Builder
{
    public class CarDirector
    {
        private ICarBuilder _builder;
        public CarDirector(ICarBuilder builder)
        {
            _builder = builder;
        }

        public Car BuildCar()
        {
            return _builder
            .BuildMake("Toyota")
            .BuildModel("Vios")
            .BuildColor("White")
            .BuildDoors(2)
            .BuildYear(5)
            .BuildOriginal("Japan")
            .Build();
        }
    }
}
