using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Helpers
{
    public interface IProduct
    {
        void IntroduceYourSelf(string owner);
        IProduct CreateProduct();
    }
}
