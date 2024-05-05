using Figure.CalculationArea;
using Figure.Interfaces;
using Moq;
using Xunit;

namespace Figure.Test.CalculationArea
{
    public class CircleAreaTest
    {

        [Fact]

        public void Test_return_area_of_a_circle_equals_expected()
        {
            // Arrange
            double expected = 0.15915963711602737;
            var radius = 1;

            var area = new CircleArea(radius);

            // Act

            var result = area.Calculation();

            // Assert

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_equal_to_expected_type()
        {
            // Arrange
            var radius = 1;

            var area = new CircleArea(radius);

            // Act

            var result = area.Calculation();

            // Assert

            Assert.IsType(typeof(double), result);
        }

    }
}
