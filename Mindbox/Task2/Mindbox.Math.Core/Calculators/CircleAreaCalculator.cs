using Mindbox.Math.Core.Shapes;

namespace Mindbox.Math.Core.Calculators
{
    public class CircleAreaCalculator : IAreableCalculator
    {
        private readonly Circle _circle;

        public CircleAreaCalculator(Circle circle)
        {
            _circle = circle;
        }

        public double Calculate()
        {
            var area = System.Math.PI * _circle.Radius * _circle.Radius;
            return area;
        }
    }
}