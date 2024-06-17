using GetSquareShapes.Factories;
using Xunit;

namespace GetSquareShapes.Tests;

public class CircleTest
{
    [Theory]
    [InlineData(10)]
    [InlineData(20)]
    [InlineData(30)]
    public void Handle_ShouldReturnSquare(double radius)
    {
        var circle = ShapeFactory.CreateCircle(radius);

        var actual = circle.GetSquareShape();
        
        Assert.Equal(actual, Math.PI * Math.Pow(radius, 2));
    }

    [Fact]
    public void Handle_ShouldReturnThrow()
    {
        var exceptionActual = Assert.Throws<ArgumentException>(() => ShapeFactory.CreateCircle(-10));
        Assert.Equal("Radius must be positive (Parameter 'radius')", exceptionActual.Message);
    }
}