using Figure.ChackingErrors;
using Figure.Interfaces;

namespace Figure.CalculationArea
{
    public class TriangleArea : ICalculation
    {
        private  double a;
        private  double b;
        private  double c;

        public TriangleArea(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Calculation()
        {
            CheckingValues.CheckingForNegativeValue(this);
            var semiperimeter = (a + b + c) / 2;

            var expression = semiperimeter * (semiperimeter - a) * (semiperimeter - b) * (semiperimeter - c);

            var square = Math.Sqrt(expression);

            return square;
        }
    }
}
