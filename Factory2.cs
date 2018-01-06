using Patterns.Helpers;

namespace Patterns.Create_AbstractFactory
{
    public class Factory2 : AbstractFactory
    {
        public override ICache CreateCache()
        {
            return new MemoryCache();
        }

        public override IProduct CreateProduct()
        {
            return new NormalProduct();
        }
    }
}
