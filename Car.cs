using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Create_Builder
{
    public class Car
    {
        public string Model { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public int Doors { get; set; }
        public string Color { get; set; }
        public string Original { get; set; } 

        public void ShowCarInfo()
        {
            Console.WriteLine(string.Concat("Make: ", Make, ", Model: ", Model));
            Console.ReadLine();
        }
    }
}
