using Mindbox.Math.Core.Calculators;

namespace Mindbox.Math.Core.Shapes
{
    /// <summary> Фигура круг </summary>
    public class Circle : IAreable
    {
        /// <summary> Радиус круга </summary>
        public double Radius { get; set; }

        /// <summary> Получить калькулятор площади </summary>
        public IAreableCalculator GetAreaCalculator()
        {
            return new CircleAreaCalculator(this);
        }
    }
}