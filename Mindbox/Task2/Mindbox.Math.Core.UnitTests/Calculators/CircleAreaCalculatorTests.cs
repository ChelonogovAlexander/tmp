using AutoFixture;
using AutoFixture.AutoNSubstitute;
using FluentAssertions;
using Mindbox.Math.Core.Calculators;
using Mindbox.Math.Core.Shapes;
using NUnit.Framework;

namespace Mindbox.Math.Core.UnitTests.Calculators
{
    [TestFixture]
    public class CircleAreaCalculatorTests
    {
        private readonly IFixture _fixture = new Fixture().Customize(new AutoNSubstituteCustomization());

        [Test]
        [TestCase(0, 0)]
        [TestCase(1.2, 4.5238934211693023)]
        [TestCase(78, 19113.4497044403)]
        public void Test_Calculate(double radius, double expectedArea)
        {
            //Arrange
            var circle = new Circle { Radius = radius };

            //Act
            var service = new CircleAreaCalculator(circle);
            var actual = service.Calculate();

            //Assert
            actual.Should().Be(expectedArea);
        }
    }
}
