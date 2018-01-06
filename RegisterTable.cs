using Patterns.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Create_Factory
{
    public static class RegisterTable
    {
        public static Hashtable ReflectionProducts = new Hashtable();
        public static Hashtable NonReflectionProducts = new Hashtable();
        public static void RegisterReflectionProducts()
        {
            ReflectionProducts.Add((int)ProductType.Normal, "Patterns.Helpers.NormalProduct");
            ReflectionProducts.Add((int)ProductType.Fresh, "Patterns.Helpers.FreshProduct");
        }
        public static void RegisterNonReflectionProducts()
        {
            NonReflectionProducts.Add((int)ProductType.Normal, new NormalProduct());
            NonReflectionProducts.Add((int)ProductType.Fresh, new FreshProduct());
        }
    }
}
