public class Circle : IDrawable
{
    public int Radius { get; private set; }

    public Circle(int radius)
    {
        this.Radius = radius;
    }

    public void Draw()
    {
        double rIn = this.Radius - 0.4;
        double rOut = this.Radius + 0.4;

        for (double y = this.Radius; y >= -this.Radius; --y)
        {
            for (double x = -this.Radius; x < rOut; x += 0.5)
            {
                double value = x * x + y * y;

                if (value >= rIn * rIn && value <= rOut * rOut)
                {
                    System.Console.Write("*");
                }
                else
                {
                    System.Console.Write(" ");
                }

            }
            System.Console.WriteLine();
        }
    }
}