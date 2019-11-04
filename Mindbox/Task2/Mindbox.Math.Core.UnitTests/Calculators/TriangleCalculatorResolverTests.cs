using AutoFixture;
using AutoFixture.AutoNSubstitute;
using FluentAssertions;
using Mindbox.Math.Core.Calculators;
using Mindbox.Math.Core.Shapes;
using NSubstitute;
using NUnit.Framework;

namespace Mindbox.Math.Core.UnitTests.Calculators
{
    [TestFixture]
    public class TriangleCalculatorResolverTests
    {
        private readonly IFixture _fixture = new Fixture().Customize(new AutoNSubstituteCustomization());

        [Test]
        public void Test_Resolve_Return_RectangularTriangleAreaCalculator_if_Triangle_Is_Rectangular()
        {
            //Arrange
            var triangle = _fixture.Create<Triangle>();
            var rectangularTriangleAreaCalculator = new RectangularTriangleAreaCalculator(triangle);
            var triangleAreaCommonCalculator = new TriangleAreaCommonCalculator(triangle);
            var trianglePropertiesCalculator = _fixture.Create<ITrianglePropertiesCalculator>();
            trianglePropertiesCalculator.IsRectangular(triangle).Returns(true);

            //Act
            var service = new TriangleCalculatorResolver(rectangularTriangleAreaCalculator, triangleAreaCommonCalculator, trianglePropertiesCalculator);
            var actual = service.Resolve(triangle);

            //Assert
            actual.Should().BeOfType<RectangularTriangleAreaCalculator>();
            actual.Should().Be(rectangularTriangleAreaCalculator);
            trianglePropertiesCalculator.Received(1).IsRectangular(triangle);
            trianglePropertiesCalculator.ReceivedCalls().Should().HaveCount(1);
        }

        [Test]
        public void Test_Resolve_Return_TriangleAreaCommonCalculator_if_Triangle_Is_Not_Rectangular()
        {
            //Arrange
            var triangle = _fixture.Create<Triangle>();
            var rectangularTriangleAreaCalculator = new RectangularTriangleAreaCalculator(triangle);
            var triangleAreaCommonCalculator = new TriangleAreaCommonCalculator(triangle);
            var trianglePropertiesCalculator = _fixture.Create<ITrianglePropertiesCalculator>();
            trianglePropertiesCalculator.IsRectangular(triangle).Returns(false);

            //Act
            var service = new TriangleCalculatorResolver(rectangularTriangleAreaCalculator, triangleAreaCommonCalculator, trianglePropertiesCalculator);
            var actual = service.Resolve(triangle);

            //Assert
            actual.Should().BeOfType<TriangleAreaCommonCalculator>();
            actual.Should().Be(triangleAreaCommonCalculator);
            trianglePropertiesCalculator.Received(1).IsRectangular(triangle);
            trianglePropertiesCalculator.ReceivedCalls().Should().HaveCount(1);
        }
    }
}
