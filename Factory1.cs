using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Helpers;

namespace Patterns.Create_AbstractFactory
{
    public class Factory1 : AbstractFactory
    {
        public override ICache CreateCache()
        {
            return new RedisCache();
        }

        public override IProduct CreateProduct()
        {
            return new FreshProduct();
        }
    }
}
