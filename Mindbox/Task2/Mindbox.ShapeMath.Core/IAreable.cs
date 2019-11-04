namespace Mindbox.Math.Core
{
    /// <summary> Фигура, имеющая геометрическую площадь </summary>
    public interface IAreable
    {
        /// <summary> Получить калькулятор площади </summary>
       IAreableCalculator GetAreaCalculator();
    }
}