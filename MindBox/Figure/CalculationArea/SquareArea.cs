using Figure.ChackingErrors;
using Figure.Interfaces;

namespace Figure.CalculationArea
{
    public class SquareArea : ICalculation
    {
        private readonly double side;

        public SquareArea(double side)
        {
            this.side = side;
        }

        public double Calculation()
        {
            CheckingValues.CheckingForNegativeValue(this);
            return side * side;

        }
    }
}
