using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Create_Prototype
{
    public abstract class ConfigPrototype
    {
        public int Id { get; set; }
        public ConfigPrototype(int id)
        {
            Id = id;
        }

        public abstract ConfigPrototype Clone();
    }
}
