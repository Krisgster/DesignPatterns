using Patterns.Create_Factory;
using Patterns.Helpers;

namespace Patterns.Create_FactoryMethod
{
    public abstract class Creator
    {
        /// <summary>
        /// This is factory method to create instance, will be implement by sub class
        /// </summary>
        /// <returns></returns>
        protected abstract IProduct CreateInstance();
        public void IntroduceInstance()
        {
            IProduct instance = CreateInstance();
            instance.IntroduceYourSelf("Factory Method");
        }
    }
}
