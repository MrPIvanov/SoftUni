using System;

public class Circle : Shape
{
    public double Radius { get; protected set; }

    public Circle(double radius)
    {
        this.Radius = radius;
    }

    public override double CalculateArea()
    {
        return this.Radius * this.Radius * Math.PI;

    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * this.Radius;
    }

    public override string Draw()
    {
        return base.Draw() + "Circle";
    }
}