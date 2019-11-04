using Mindbox.Math.Core.Shapes;

namespace Mindbox.Math.Core.Calculators
{
    public class TriangleCalculatorResolver : ITriangleCalculatorResolver
    {
        private readonly RectangularTriangleAreaCalculator _rectangularTriangleAreaCalculator;
        private readonly TriangleAreaCommonCalculator _triangleAreaCommonCalculator;
        private readonly ITrianglePropertiesCalculator _trianglePropertiesCalculator;

        public TriangleCalculatorResolver(
            RectangularTriangleAreaCalculator rectangularTriangleAreaCalculator,
            TriangleAreaCommonCalculator triangleAreaCommonCalculator,
            ITrianglePropertiesCalculator trianglePropertiesCalculator)
        {
            _rectangularTriangleAreaCalculator = rectangularTriangleAreaCalculator;
            _triangleAreaCommonCalculator = triangleAreaCommonCalculator;
            _trianglePropertiesCalculator = trianglePropertiesCalculator;
        }

        public IAreableCalculator Resolve(Triangle triangle)
        {
            if (_trianglePropertiesCalculator.IsRectangular(triangle))
                return _rectangularTriangleAreaCalculator;

            return _triangleAreaCommonCalculator;
        }
    }
}
