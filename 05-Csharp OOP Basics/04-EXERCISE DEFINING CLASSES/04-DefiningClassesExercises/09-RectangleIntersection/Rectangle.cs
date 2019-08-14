using System;

public class Rectangle
{
    public string Id { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }
    public double TopLeftX { get; set; }
    public double TopLeftY { get; set; }

    public Rectangle(string inputRectangle)
    {
       var args = inputRectangle.Split();
        Id = args[0];
        Width = Math.Abs(double.Parse(args[1]));
        Height = Math.Abs(double.Parse(args[2]));
        TopLeftX = double.Parse(args[3]);
        TopLeftY = double.Parse(args[4]);
       
    }

    public bool IsThereIntersection(Rectangle rectangle)
    {
        return rectangle.TopLeftX + rectangle.Width >= this.TopLeftX &&
                rectangle.TopLeftX <= this.TopLeftX + this.Width &&
                rectangle.TopLeftY >= this.TopLeftY - this.Height &&
                rectangle.TopLeftY - rectangle.Height <= this.TopLeftY;
    }
}