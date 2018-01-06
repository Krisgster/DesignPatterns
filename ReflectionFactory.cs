using Patterns.Helpers;
using System;
using System.Reflection;

namespace Patterns.Create_Factory
{
    //http://www.oodesign.com/factory-pattern.html
    public class ReflectionFactory
    {        
        public static IProduct CreateProduct(int productType)
        {
            string productName = (string)RegisterTable.ReflectionProducts[productType];
            Type type = Type.GetType(productName);
            ConstructorInfo constructor = type.GetConstructor(Type.EmptyTypes);
            return (IProduct)constructor.Invoke(Type.EmptyTypes);
        }
    }
}
