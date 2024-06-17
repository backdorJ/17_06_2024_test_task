using GetSquareShapes.Interfaces;
using GetSquareShapes.Models;

namespace GetSquareShapes.Factories;

public class ShapeFactory
{
    public static IShape CreateCircle(double radius)
        => new Circle(radius);

    public static IShape CreateTriangle(double firstSide, double secondSide, double thirdSide)
        => new Triangle(firstSide, secondSide, thirdSide);
}