using Patterns.Create_AbstractFactory;
using Patterns.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Clients
{
    public class AbstractFactoryClient
    {
        public static void RunDemo()
        {
            AbstractFactory factory = new Factory1();
            IProduct product = factory.CreateProduct();
            ICache cache = factory.CreateCache();

            product.IntroduceYourSelf("Abstract factory");
            cache.Write("xx");
        }
    }
}
