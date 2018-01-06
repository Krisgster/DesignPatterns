using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Helpers
{
    public interface ICache
    {
        void Write(string key);
        void Read(string key);
    }
}
