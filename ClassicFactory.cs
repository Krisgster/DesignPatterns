using Patterns.Helpers;

namespace Patterns.Create_Factory
{
    //http://www.oodesign.com/factory-pattern.html
    public class ClassicFactory
    {
        public IProduct CreateProduct(int type)
        {
            if (type == (int)ProductType.Normal)
                return new NormalProduct();
            if (type == (int)ProductType.Fresh)
                return new FreshProduct();

            return null;
        }
    }
}
