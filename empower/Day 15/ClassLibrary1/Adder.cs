using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class Adder
    {
        private readonly List<int> values = new List<int>();

        public void Add(int value)
        {
            values.Add(value);

        }
        public int Calculate()
        {
            var total = 0;
            foreach (var value in values)
            {
                total += value;
            }
            return total;
        }
    }
}

