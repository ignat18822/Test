using Figure.ChackingErrors;
using Figure.Interfaces;

namespace Figure.CalculationArea
{
    public class PolygonArea : ICalculation
    {
        private  List<double> sides;

        public PolygonArea(List<double> sides)
        {
            this.sides = sides;
        }
        public double Calculation()
        {
            CheckingValues.CheckingForNegativeValue(this);

            double expression = 1;

            var semiperimeter = sides.Sum() / 2;

            foreach (var side in sides)
            {
                expression *= semiperimeter - side;
            }

            var square = Math.Sqrt(expression * semiperimeter);

            return square;
        }
    }
}
