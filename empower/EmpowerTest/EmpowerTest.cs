using System;
using Xunit;

namespace netcoretesting
{
    public class EmpowerTest 
    {
        [Fact]
        public void TwoPlusTwoEqualsFour() 
        {
            var result = 2+ 2;
            Assert.Equal(4, results);
        }
        [Theory]
        [InlineData(3,False)]
        [InlineData(4,True)]
        [inLineData(1,False)]

        public void WhenAddedToTwoShouldEqualFour(int thingToAdd, bool expectedResult) {
            var result = 2+ thingToAdd;
            Assert.Equal((result == 4), expectedResult);
        }
        [Fact]
        public void CatMakesAMeowNoise() {
            var mock = new Mock<IMakeALoudNoise>();
            mock.Setup(x => x.MakeALoudNoise()).Returns("Meow!");

            var cat = new Cat(mock.Object);
            var result = cat.MakeALoudNoise();

            Assert.Equal("Meow!", result);
            
        }
    }
}