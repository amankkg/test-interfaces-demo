using FizzBuzzClassLibrary;
using Xunit;

namespace FizzBuzzTest
{
    public class EvenOddTest
    {
        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(-6)]
        [InlineData(-42)]
        public void TestEven(int number)
        {
            var actual = EvenOdd.Check(number);

            Assert.True(actual);
        }

        [Fact]
        public void TestZero()
        {
            var number = 0;
            bool? expected = null;

            var actual = EvenOdd.Check(number);

            Assert.Equal(expected, actual);
        }
    }
}
