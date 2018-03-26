using System;
using System.Collections.Generic;
using System.Text;

public class Rectangle
{
    public int X1 { get; set; }
    public int X2 { get; set; }
    public int Y1 { get; set; }
    public int Y2 { get; set; }


    public Rectangle(Point topLeft, Point bottomRight)
    {
        X1 = topLeft.X;
        Y1 = topLeft.Y;
        X2 = bottomRight.X;
        Y2 = bottomRight.Y;
    }

    public bool Contains(Point curentPoint)
    {
        if (curentPoint.X>=X1 && curentPoint.X<=X2 && curentPoint.Y>=Y1 && curentPoint.Y<=Y2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
