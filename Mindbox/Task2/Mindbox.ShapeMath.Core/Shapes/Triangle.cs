using Mindbox.Math.Core.Calculators;

namespace Mindbox.Math.Core.Shapes
{
    /// <summary> Треугольник </summary>
    public class Triangle : IAreable
    {
        /// <summary> Сторона A </summary>
        public double SideA { get; set; }

        /// <summary> Сторона B </summary>
        public double SideB { get; set; }

        /// <summary> Сторона C </summary>
        public double SideC { get; set; }

        public IAreableCalculator GetAreaCalculator()
        {
            var resolver = new TriangleCalculatorResolver(
                new RectangularTriangleAreaCalculator(this),
                new TriangleAreaCommonCalculator(this),
                new TrianglePropertiesCalculator());

            return new TriangleAreaCalculator(this, resolver);
        }
    }
}