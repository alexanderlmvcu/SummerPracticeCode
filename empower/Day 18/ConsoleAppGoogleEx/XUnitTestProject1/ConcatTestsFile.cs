using System;
using Xunit;
using ConsoleAppGoogleEx;

namespace XUnitTestProject1
{
    public class ConcatTestsFile
    {
        [Fact]
        public void WorksCorrectly()
        {
            var cc = new ConcatClass();
            var result = cc.ConcatThis("Alpha", "Bravo");
            Assert.Equal("AlphaBravo", result);
        }
    }
}
