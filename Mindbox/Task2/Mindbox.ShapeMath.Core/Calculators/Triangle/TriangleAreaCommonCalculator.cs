using Mindbox.Math.Core.Shapes;

namespace Mindbox.Math.Core.Calculators
{
    public class TriangleAreaCommonCalculator : IAreableCalculator
    {
        private readonly Triangle _triangle;

        public TriangleAreaCommonCalculator(Triangle triangle)
        {
            _triangle = triangle;
        }

        public double Calculate()
        {
            var semiPerimeter = (_triangle.SideA + _triangle.SideB + _triangle.SideC) / 2.0;
            var semiPerimeterWithoutA = semiPerimeter - _triangle.SideA;
            var semiPerimeterWithoutB = semiPerimeter - _triangle.SideB;
            var semiPerimeterWithoutC = semiPerimeter - _triangle.SideC;

            var area = System.Math.Sqrt(semiPerimeter * semiPerimeterWithoutA * semiPerimeterWithoutB * semiPerimeterWithoutC);

            return area;
        }
    }
}
