using GetSquareShapes.Interfaces;

namespace GetSquareShapes.Models;

public class Circle : IShape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius must be positive", nameof(radius));
        
        Radius = radius;
    }
    
    /// <inheritdoc />
    public double GetSquareShape()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}