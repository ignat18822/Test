using Figure.ChackingErrors;
using Figure.Interfaces;

namespace Figure.CalculationArea
{
    public class CircleArea : ICalculation
    {
        private  double radius;
        public CircleArea(double radius)
        {
            this.radius = radius;
        }

        public double Calculation()
        {
            CheckingValues.CheckingForNegativeValue(this);

            return radius / (Coefficients.Pi * 2);
        }
    }
}