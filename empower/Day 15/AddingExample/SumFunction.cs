using System;

namespace AddingExample
{
    public class SumFunction : IAggregate
    {
        private int sum;
        public int Calculate()
        {
            return sum;
        }
        public void Insert(int value)
        {
            sum += value;
        }
    }
}
