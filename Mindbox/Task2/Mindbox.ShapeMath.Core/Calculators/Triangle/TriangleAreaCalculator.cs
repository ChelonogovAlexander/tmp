using Mindbox.Math.Core.Shapes;

namespace Mindbox.Math.Core.Calculators
{
    public class TriangleAreaCalculator : IAreableCalculator
    {
        private readonly Triangle _triangle;
        private readonly ITriangleCalculatorResolver _triangleCalculatorResolver;

        public TriangleAreaCalculator(Triangle triangle, ITriangleCalculatorResolver triangleCalculatorResolver)
        {
            _triangle = triangle;
            _triangleCalculatorResolver = triangleCalculatorResolver;
        }

        public double Calculate()
        {
            var calculator = _triangleCalculatorResolver.Resolve(_triangle);
            return calculator.Calculate();
        }
    }
}
