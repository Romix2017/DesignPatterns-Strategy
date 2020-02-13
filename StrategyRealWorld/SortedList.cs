using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyRealWorld
{
    public class SortedList
    {
        private List<string> list = new List<string>();
        private SortStrategy sortStrategy;
        public void SetSortStrategy(SortStrategy sortStrategy)
        {
            this.sortStrategy = sortStrategy;
        }
        public void Add(string name)
        {
            list.Add(name);
        }
        public void Sort()
        {
            sortStrategy.Sort(list);
            foreach (string name in list)
            {
                Console.WriteLine(" " + name);
            }
            Console.WriteLine();
        }
    }
}
