using FizzBuzzClassLibrary;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzCheckTest
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(30, "FizzBuzz")]
        public void TestPositive(int number, string expected)
        {
            // Act
            var actual = FizzBuzzCheck.Check(number);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-1, "-1")]
        [InlineData(-3, "Fizz")]
        [InlineData(-5, "Buzz")]
        [InlineData(-15, "FizzBuzz")]
        [InlineData(-30, "FizzBuzz")]
        public void TestNegative(int number, string expected)
        {
            // Act
            var actual = FizzBuzzCheck.Check(number);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestZero()
        {
            // Arrange
            var number = 0;
            var expected = number.ToString();

            // Act
            var actual = FizzBuzzCheck.Check(number);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
