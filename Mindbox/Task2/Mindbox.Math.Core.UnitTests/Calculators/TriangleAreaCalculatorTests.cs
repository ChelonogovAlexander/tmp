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
    public class TriangleAreaCalculatorTests
    {
        private readonly IFixture _fixture = new Fixture().Customize(new AutoNSubstituteCustomization());

        [Test]
        public void Test_Calculate()
        {
            //Arrange
            var triangle = _fixture.Create<Triangle>();
            var resolver = _fixture.Create<ITriangleCalculatorResolver>();
            var calculator = _fixture.Create<IAreableCalculator>();
            resolver.Resolve(triangle).Returns(calculator);

            //Act
            var service = new TriangleAreaCalculator(triangle, resolver);
            var actual = service.Calculate();

            //Assert
            resolver.Received(1).Resolve(triangle);
            calculator.Received(1).Calculate();
            resolver.ReceivedCalls().Should().HaveCount(1);
            calculator.ReceivedCalls().Should().HaveCount(1);
            actual.Should().Be(calculator.Calculate());
        }
    }
}
