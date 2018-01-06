using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Create_Builder
{
    public interface ICarBuilder
    {
        ICarBuilder BuildMake(string make);
        ICarBuilder BuildModel(string model);
        ICarBuilder BuildYear(int year);
        ICarBuilder BuildDoors(int doors);
        ICarBuilder BuildColor(string color);
        ICarBuilder BuildOriginal(string original);
        Car Build();
    }
}
