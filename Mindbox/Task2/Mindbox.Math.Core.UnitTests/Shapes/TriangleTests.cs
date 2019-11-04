using AutoFixture;
using AutoFixture.AutoNSubstitute;
using FluentAssertions;
using Mindbox.Math.Core.Calculators;
using Mindbox.Math.Core.Shapes;
using NUnit.Framework;

namespace Mindbox.Math.Core.UnitTests.Shapes
{
    [TestFixture]
    public class TriangleTests
    {
        private readonly IFixture _fixture = new Fixture().Customize(new AutoNSubstituteCustomization());

        [Test]
        public void Test_GetAreaCalculator_Return_CircleAreaCalculator()
        {
            //Arrange
            var triangle = _fixture.Create<Triangle>();

            //Act
            var calculator = triangle.GetAreaCalculator();

            //Assert
            calculator.Should().BeOfType<TriangleAreaCalculator>();
        }
    }
}
