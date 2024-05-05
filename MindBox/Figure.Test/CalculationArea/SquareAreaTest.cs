using Figure.CalculationArea;
using Xunit;

namespace Figure.Test.CalculationArea
{
    public class SquareAreaTest
    {
        [Fact]

        public void Test_return_area_of_a_square_equals_expected()
        {
            // Arrange
            double expected = 4;
            var side = 2;

            var area = new SquareArea(side);

            // Act

            var result = area.Calculation();

            // Assert

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_equal_to_expected_type()
        {
            // Arrange
            var side = 2;

            var area = new SquareArea(side);

            // Act

            var result = area.Calculation();

            // Assert

            Assert.IsType(typeof(double), result);
        }
    }
}
