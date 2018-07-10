﻿public class Rectangle : Shape
{
    public double Height { get; protected set; }
    public double Width { get; protected set; }

    public Rectangle(double height, double width)
    {
        this.Height = height;
        this.Width = width;
    }

    public override double CalculateArea()
    {
        return this.Height * this.Width;
                    
    }

    public override double CalculatePerimeter()
    {
        return 2 * (this.Height + this.Width);
    }

    public override string Draw()
    {
        return base.Draw() + "Rectangle";
    }
}