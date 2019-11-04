using Mindbox.Math.Core.Shapes;
using System.Linq;

namespace Mindbox.Math.Core.Calculators
{
    public class TrianglePropertiesCalculator : ITrianglePropertiesCalculator
    {
        public bool IsRectangular(Triangle triangle)
        {
            var hypotenuse = System.Math.Max(System.Math.Max(triangle.SideA, triangle.SideB), triangle.SideC);

            var triangleLegs = new[] { triangle.SideA, triangle.SideB, triangle.SideC }
                              .OrderBy(a => a)
                              .Take(2)
                              .ToArray();

            var legA = triangleLegs[0];
            var legB = triangleLegs[1];

            var isRectangular = legA * legA + legB * legB == hypotenuse * hypotenuse;

            return isRectangular;
        }
    }
}
