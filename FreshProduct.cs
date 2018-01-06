using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Helpers
{
    public class FreshProduct : IProduct
    {
        public void IntroduceYourSelf(string owner)
        {
            Console.WriteLine("Hello, I am FRESH product! I was created by {0}", owner);
        }


        #region NonReflection factory only

        public IProduct CreateProduct()
        {
            return new FreshProduct();
        }

        #endregion
    }
}
