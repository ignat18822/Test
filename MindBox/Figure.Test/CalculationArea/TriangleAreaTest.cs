using Figure.CalculationArea;
using Xunit;

namespace Figure.Test.CalculationArea
{
    public class TriangleAreaTest
    {
        [Fact]

        public void Test_return_area_of_a_triangle_equals_expected()
        {
            // Arrange
            double expected = 3.799671038392666;
            var a = 2;
            var b = 4;
            var c = 5;

            var area = new TriangleArea(a, b, c);

            // Act

            var result = area.Calculation();

            // Assert

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_equal_to_expected_type()
        {
            // Arrange
            var a = 2;
            var b = 4;
            var c = 5;

            var area = new TriangleArea(a, b, c);

            // Act

            var result = area.Calculation();

            // Assert

            Assert.IsType(typeof(double), result);
        }
    }
}
