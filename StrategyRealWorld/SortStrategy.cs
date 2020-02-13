using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyRealWorld
{
    public abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }
}
