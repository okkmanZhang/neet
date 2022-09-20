using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge.design
{
    public interface IStrategy
    {
        int Compute(int input1, int input2);
    }

    public class AddStrategy : IStrategy
    {
        public int Compute(int input1, int input2)
        {
            return input1 + input2;
        }
    }

    public class MultiplyStrategy : IStrategy
    {
        public int Compute(int input1, int input2)
        {
            return input1 * input2;
        }
    }

    public class StrategyDemo
    {

        private IStrategy _strategy;
        public StrategyDemo(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public int Compute(int input1, int input2)
        {
            return _strategy.Compute(input1, input2);
        }
    }

    public class StrategyClient
    {
        public static int Run()
        {
            var strategy = new AddStrategy();
            var strategy2 = new MultiplyStrategy();
            var demo = new StrategyDemo(strategy);
            var demo2 = new StrategyDemo(strategy2);

            return demo2.Compute(2,3);
        }
    }
}
