using Figure.CalculationArea;
using System.Drawing;
using Xunit;

namespace Figure.Test.CalculationArea
{
    public class RectangleAreaTest
    {

        [Fact]

        public void Test_return_area_of_a_rectangle_equals_expected()
        {
            // Arrange
            double expected = 8;
            var height = 2;
            var weight = 4;

            var area = new RectangleArea(height, weight);

            // Act

            var result = area.Calculation();

            // Assert

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_equal_to_expected_type()
        {
            // Arrange
            var height = 2;
            var weight = 4;

            var area = new RectangleArea(height, weight);

            // Act

            var result = area.Calculation();

            // Assert

            Assert.IsType(typeof(double), result);
        }
    }
}
