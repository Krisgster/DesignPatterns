using Patterns.Create_Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Clients
{
    public class PrototypeClient
    {
        public static void RunDemo()
        {
            ConfigPrototype rootPrototype = new ConreateConfigPrototype(52);
            ConfigPrototype copyPrototype = rootPrototype.Clone();
            copyPrototype.Id = copyPrototype.Id + 1;

            Console.Write("Root prototype ID: {0}", rootPrototype.Id);
            Console.Write("\n");
            Console.Write("Copy prototype ID: {0}", copyPrototype.Id);

            
            Console.ReadLine();
        }
    }
}
