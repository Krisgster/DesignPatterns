using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Create_Factory;
using Patterns.Helpers;

namespace Patterns.Create_FactoryMethod
{
    public class ConreteCreator : Creator,IProduct
    {
        public IProduct CreateProduct()
        {
            throw new NotImplementedException();
        }

        public void IntroduceYourSelf(string owner)
        {
            Console.WriteLine("Hello, I am concrete creator! I was created by {0}", owner);
        }

        protected override IProduct CreateInstance()
        {
            return new ConreteCreator();
        }
    }
}
