using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Context
    {
        private Strategy strategy;
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }
        public void ContextInterface()
        {
            strategy.AlgorithmInterface();
        }
    }
}
