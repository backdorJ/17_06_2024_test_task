using GetSquareShapes.Interfaces;

namespace GetSquareShapes.Models;

public class Triangle : IShape
{
    private double SideA { get; }
    private double SideB { get; }
    private double SideC { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            throw new ArgumentException("All sides must be positive");
        if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            throw new ArgumentException("The given sides do not form a triangle");

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }
    
    /// <inheritdoc />
    public double GetSquareShape()
    {
        var halfPerimeter = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC));
    }
    
    public bool IsRightAngled()
    {
        var sides = new[] { SideA, SideB, SideC };
        Array.Sort(sides);
        return Math.Abs(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) < 1e-10;
    }
}