﻿using Patterns.Create_Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Clients
{
    public class BuilderClient
    {
        public static void RunDemo()
        {
            Car car = new CarBuilder()
            .BuildMake("Toyota")
            .BuildModel("Vios")
            .BuildColor("White")
            .BuildDoors(2)
            .BuildYear(5)
            .BuildOriginal("Japan")
            .Build();

            car.ShowCarInfo();
        }
    }
}
