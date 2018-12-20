using System;

class StartUp
{
    static void Main()
    {
        var figure = Console.ReadLine();
        var cols = 0;
        var rows = 0;
        if (figure=="Rectangle")
        {
            cols = int.Parse(Console.ReadLine());
            rows = int.Parse(Console.ReadLine());
        }
        else
        {
            cols = int.Parse(Console.ReadLine());
            rows = cols;
        }

        var firure = new DrawingTool(cols, rows);

        firure.Draw();


    }
}