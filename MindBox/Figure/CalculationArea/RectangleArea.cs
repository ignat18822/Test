using Figure.ChackingErrors;
using Figure.Interfaces;

namespace Figure.CalculationArea
{
    public class RectangleArea : ICalculation
    {
        private  double height;

        private  double width;

        public RectangleArea (double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public double Calculation()
        {
            CheckingValues.CheckingForNegativeValue(this);
            return height* width;
        }
        
    }
}
