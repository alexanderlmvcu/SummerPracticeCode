using System;
using Xunit;
using NameLibrary;

namespace XUnitTestProject2
{
    public class NameProcessorTests
    {
        [Fact]
        public void Test1()
        {
            var nameProcessor = new NameProcessor();
            nameProcessor.Add("bob");
            nameProcessor.Add("Alice");
            nameProcessor.Add("Bobby");
            nameProcessor.Add("alina");

            var bobs = nameProcessor.GetNamesStartingWith("Bob");
            var alis = nameProcessor.GetNamesStartingWith("Ali");
            var charlies = nameProcessor.GetNamesStartingWith("Charlie");

            Assert.Equal(2, bobs.Count);
            Assert.Equal(2, alis.Count);
            Assert.Empty(charlies);

            var bob1 = bobs[0];
            var bob2 = bobs[1];

            var ali1 = alis[0];
            var ali2 = alis[1];
            Assert.Equal("Bob", bob1);
            Assert.Equal("Bobby", bob2);
            Assert.Equal("Alice", ali1);
            Assert.Equal("Alina", ali2);
        }
    }
}
