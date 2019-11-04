using AutoFixture;
using AutoFixture.AutoNSubstitute;
using FluentAssertions;
using Mindbox.Math.Core.Calculators;
using Mindbox.Math.Core.Shapes;
using NUnit.Framework;

namespace Mindbox.Math.Core.UnitTests.Shapes
{
    [TestFixture]
    public class CircleTests
    {
        private readonly IFixture _fixture = new Fixture().Customize(new AutoNSubstituteCustomization());

        [Test]
        public void Test_GetAreaCalculator_Return_CircleAreaCalculator()
        {
            //Arrange
            var circle = _fixture.Create<Circle>();

            //Act
            var calculator = circle.GetAreaCalculator();

            //Assert
            calculator.Should().BeOfType<CircleAreaCalculator>();
        }
    }
}
