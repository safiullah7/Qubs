using Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qubs.Store.Counter
{
    public static class CounterReducer
    {
        [ReducerMethod]
        public static CounterState OnAddCounter(CounterState state, AddCounter action)
            => state with
            {
                Count = action.Count
            };
    }
}
