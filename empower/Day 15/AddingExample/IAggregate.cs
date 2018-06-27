using System;

namespace AddingExample
{
    public interface IAggregate
    {
        void Insert(int value);
        int Calculate();
    }
}
