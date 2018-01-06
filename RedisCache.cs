using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Helpers
{
    public class RedisCache : ICache
    {
        public void Read(string key)
        {
            Console.WriteLine("Here is redis cache data");
        }

        public void Write(string key)
        {
            Console.WriteLine("Redis cache has been written");
        }
    }
}
