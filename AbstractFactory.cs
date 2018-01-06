using Patterns.Helpers;

namespace Patterns.Create_AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract IProduct CreateProduct();
        public abstract ICache CreateCache();
    }
}
