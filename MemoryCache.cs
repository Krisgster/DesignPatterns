using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Helpers
{
    public class MemoryCache : ICache
    {
        public void Read(string key)
        {
            Console.WriteLine("Here is memory cache data");
        }

        public void Write(string key)
        {
            Console.WriteLine("Memory cache has been written");
        }
    }
}
