using System;
using Xunit;
using ClassLibrary1;

namespace XUnitTestProject1
{
    public class AdderTests
    {
        [Fact]
        public void CalculatesCorrectly()
        {
            var adder = new Adder();
            adder.Add(1);
            adder.Add(2);
            adder.Add(3);
            var result = adder.Calculate();
            Assert.Equal(6, result);
        }
    }
}
