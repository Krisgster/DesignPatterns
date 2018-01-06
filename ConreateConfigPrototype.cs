using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Create_Prototype
{
    public class ConreateConfigPrototype : ConfigPrototype
    {
        public ConreateConfigPrototype(int id) : base(id)
        {

        }
        public override ConfigPrototype Clone()
        {
            return (ConfigPrototype)this.MemberwiseClone();
        }
    }
}
