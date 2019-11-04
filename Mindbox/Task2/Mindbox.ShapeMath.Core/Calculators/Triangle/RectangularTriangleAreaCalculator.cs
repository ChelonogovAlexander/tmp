using Mindbox.Math.Core.Shapes;
using System.Linq;

namespace Mindbox.Math.Core.Calculators
{
    public class RectangularTriangleAreaCalculator : IAreableCalculator
    {
        private readonly Triangle _triangle;

        public RectangularTriangleAreaCalculator(Triangle triangle)
        {
            _triangle = triangle;
        }

        public double Calculate()
        {
            var triangleLegs = new[] { _triangle.SideA, _triangle.SideB, _triangle.SideC }
                              .OrderBy(a => a)
                              .Take(2)
                              .ToArray();
            var legA = triangleLegs[0];
            var legB = triangleLegs[1];



            var area = 0.5 * legA * legB;

            return area;
        }
    }
}
