public class DrawingTool
{
    public int Cols { get; set; }
    public int Rows { get; set; }


    public DrawingTool(int cols, int rows)
    {
        Cols = cols;
        Rows = rows;
    }

    internal void Draw()
    {
        for (int currentRow = 1; currentRow <= Rows; currentRow++)
        {
            if (currentRow == 1)
            {
                System.Console.Write($"|{new string ('-',Cols)}|");
            }
            else if (currentRow == Rows)
            {
                System.Console.Write($"|{new string('-', Cols)}|");
            }
            else
            {
                System.Console.Write($"|{new string(' ', Cols)}|");
            }
            System.Console.WriteLine();

        }

    }
}