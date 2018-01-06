using Patterns.Create_Factory;
using Patterns.Create_FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Clients
{
    public class FactoryMethodClient
    {
        public static void RunDemo()
        {
            Creator creator = new ConreteCreator();
            creator.IntroduceInstance();
        }
    }
}
