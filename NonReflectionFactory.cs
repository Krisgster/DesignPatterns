using Patterns.Helpers;

namespace Patterns.Create_Factory
{
    //http://www.oodesign.com/factory-pattern.html
    public static class NonReflectionFactory
    {
        public static IProduct CreateProduct(int productType)
        {
            return ((IProduct)RegisterTable.NonReflectionProducts[productType]).CreateProduct();
        }
    }
}
