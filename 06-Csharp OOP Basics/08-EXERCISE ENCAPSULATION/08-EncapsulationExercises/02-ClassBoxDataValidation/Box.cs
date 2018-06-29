using System;

public class Box
{
    private double length;
    private double width;
    private double height;

    private double Length
    {
        get { return length; }
        set
        {
            if (value<=0)
            {
                throw new ArgumentException("Length cannot be zero or negative.");
            }
            length = value;
        }
    }

    private double Width
    {
        get { return width; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }
            width = value;
        }
    }

    private double Height
    {
        get { return height; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }
            height = value;
        }
    }

    public Box(double lenght, double width, double height)
    {
        this.Length = lenght;
        this.Width = width;
        this.Height = height;
    }

    internal double CalculateSurfaceArea()
    {
        var result = 2 * Length * Width + 2 * Length * Height + 2 * Width * Height;
        return result;
    }

    internal double CalculateLateralSurfaceArea()
    {
        var result = 2 * Length * Height + 2 * Width * Height;
        return result;
    }

    internal double CalculateVolume()
    {
        var result = Length * Width * Height;
        return result;
    }
}