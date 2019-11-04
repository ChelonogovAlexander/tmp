using Mindbox.Math.Core.Shapes;

namespace Mindbox.Math.Core.Calculators
{
    public interface ITriangleCalculatorResolver
    {
        IAreableCalculator Resolve(Triangle triangle);
    }
}