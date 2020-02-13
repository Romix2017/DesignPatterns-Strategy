using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyRealWorld
{
    public class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort();
            Console.WriteLine("QuickSorted list");
        }
    }
}
