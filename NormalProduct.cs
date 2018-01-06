using System;

namespace Patterns.Helpers
{
    public class NormalProduct : IProduct
    {
        public void IntroduceYourSelf(string owner)
        {
            Console.WriteLine("Hello, I am NORMAL product! I was created by {0}", owner);
        }

        #region NonReflection factory only

        public IProduct CreateProduct()
        {
            return new NormalProduct();
        }

        #endregion   
    }
}
