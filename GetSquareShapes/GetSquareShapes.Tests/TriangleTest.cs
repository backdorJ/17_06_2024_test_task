using GetSquareShapes.Factories;
using GetSquareShapes.Models;
using Xunit;

namespace GetSquareShapes.Tests;

public class TriangleTest
{
    [Theory]
    [InlineData(3, 4, 5)]
    public void Handle_ShouldReturnCircle(double sideA, double sideB, double sideC)
    {
        var triangle = ShapeFactory.CreateTriangle(sideA, sideB, sideC);

        var triangleSquare = triangle.GetSquareShape();
        
        Assert.Equal(
            triangleSquare,
            Math.Sqrt(
                (sideA + sideB + sideC) / 2 *
                ((sideA + sideB + sideC) / 2 - sideA)
                * ((sideA + sideB + sideC) / 2 - sideB)
                * ((sideA + sideB + sideC) / 2 - sideC)));
    }

    [Fact]
    public void Handle_ShouldReturnRightTriangle()
    {
        var triangle = (Triangle)ShapeFactory.CreateTriangle(3, 4, 5);
        Assert.True(triangle.IsRightAngled());
    }
}