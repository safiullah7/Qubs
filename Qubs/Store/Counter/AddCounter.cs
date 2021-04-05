using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qubs.Store.Counter
{
    public class AddCounter
    {
        public AddCounter(int count)
        {
            Count = count;
        }

        public int Count { get; }
    }
}
