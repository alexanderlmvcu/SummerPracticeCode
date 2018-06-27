using System;

namespace AddingExample
{
    public class AverageFunction : IAggregate
    {
        private int sum;
        private int quantity;
        public int Calculate()
        {
            return sum / quantity;
        }
        public void Insert(int value)
        {
            sum += value;
            quantity++;
        }


    }
}
