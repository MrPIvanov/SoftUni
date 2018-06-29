using System;

public class Box
{
    private double Length { get; set; }
    private double Width { get; set; }
    private double Height { get; set; }

    public Box(double length, double width,double height)
    {
        Length = length;
        Width = width;
        Height = height;
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