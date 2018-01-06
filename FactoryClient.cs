using Patterns;
using Patterns.Create_Factory;
using Patterns.Helpers;

namespace DesignPatterns.Clients
{
    public class FactoryClient
    {
        public static void RunClassicFactoryDemo()
        {
            IProduct normal = new ClassicFactory().CreateProduct((int)ProductType.Normal);
            normal.IntroduceYourSelf("ClassicFactory");

            IProduct fresh = new ClassicFactory().CreateProduct((int)ProductType.Fresh);
            fresh.IntroduceYourSelf("ClassicFactory");
        }

        public static void RunReflectionFactryDemo()
        {
            RegisterTable.RegisterReflectionProducts();
            IProduct reflectionProduct = ReflectionFactory.CreateProduct((int)ProductType.Fresh);
            reflectionProduct.IntroduceYourSelf("ReflectionFactory");
        }
        public static void RunNonReflectionFactryDemo()
        {
            RegisterTable.RegisterNonReflectionProducts();
            IProduct nonReflection = NonReflectionFactory.CreateProduct((int)ProductType.Normal);
            nonReflection.IntroduceYourSelf("NonReflectionFactory");
        }
    }
}
