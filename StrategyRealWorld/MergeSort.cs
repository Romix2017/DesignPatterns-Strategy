﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyRealWorld
{
    public class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //list.MergeSort(); not implemented
            Console.WriteLine("MergeSorted list");
        }
    }
}
