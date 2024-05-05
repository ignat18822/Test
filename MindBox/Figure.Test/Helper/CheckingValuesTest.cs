using Figure.CalculationArea;
using Figure.ChackingErrors;
using Xunit;

namespace Figure.Test.Helper
{
    public class CheckingValuesTest
    {
        [Fact]
        public void Test_triangle_error_to_a_negative_number()
        {
            // Arrange
            var a = -4;
            var b = 6.43;
            var c = 7.56;
            var triangle = new TriangleArea(a,b,c);
            

            // Assert

            var ex = Assert.Throws<Exception>(() => CheckingValues.CheckingForNegativeValue(triangle));
            Assert.Equal($"Число не может быть меньше нуля. Тип {triangle.GetType()}", ex.Message);
        }

        [Fact]
        public void Test_polygon_error_to_a_negative_number()
        {
            // Arrange
            var sidesPolygon = new List<double> { -4.5, 6.543, 7, 8.546, 9 };
            var polygon = new PolygonArea(sidesPolygon);


            // Assert

            var ex = Assert.Throws<Exception>(() => CheckingValues.CheckingForNegativeValue(polygon));
            Assert.Equal($"Число не может быть меньше нуля. Тип {polygon.GetType()}", ex.Message);
        }
    }
}
