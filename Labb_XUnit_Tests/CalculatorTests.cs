using Labb_XUnit;

namespace Labb_XUnit_Tests
{
    public class CalculatorTests
    {
       
        private readonly Calculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void Addition_ShouldReturnCorrectSum()
        {
            // Arrange
            decimal x = 3;
            decimal y = 2;
            decimal expected = 5;

            // Act
            decimal result = _calculator.Addition(x, y);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(0, 3, -3)]
        [InlineData(100, 200, -100)]
        [InlineData(-5, -2, -3)]
        [InlineData(5.5, 2.5, 3)]
        public void Subtraction_ShouldReturn_CorrectDifference(decimal x, decimal y, decimal expected)
        {
            // Arrange

            // Act
            decimal result = _calculator.Subtraction(x, y);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(3, 2, 6)]
        [InlineData(10, 0, 0)]
        [InlineData(-12, -4, 48)]
        [InlineData(100, 10, 1000)]
        [InlineData(12.25, 3.5, 42.875)]
        public void Multiplication_ShouldReturn_CorrectProduct(decimal x, decimal y, decimal expected)
        {
            // Arrange

            // Act
            decimal result = _calculator.Multiplication(x, y);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(10, 5, 2)]
        [InlineData(-4, -10, 0.4)]
        [InlineData(10, 100, 0.1)]
        [InlineData(1, 4, 0.25)]
        public void Division_ShouldReturnCorrect_Quotient(decimal x, decimal y, decimal expected)
        {
            // Arrange

            // Act
            decimal result = _calculator.Divide(x, y);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Division_ByZero_Should_ThrowException()
        {
            // Arrange
            decimal x = 10;
            decimal y = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(x, y));
        }
    }
}
