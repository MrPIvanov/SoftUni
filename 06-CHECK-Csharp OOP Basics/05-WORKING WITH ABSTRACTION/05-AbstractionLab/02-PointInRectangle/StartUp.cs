using System;

public class StartUp
{
    static void Main()
    {
        var input = Console.ReadLine().Split();
        var topLeftPoint = new Point(int.Parse(input[0]), int.Parse(input[1]));
        var bottomRightPoint = new Point(int.Parse(input[2]), int.Parse(input[3]));
        var rectange = new Rectangle(topLeftPoint,bottomRightPoint);

        var numberOfPointsToCheck = int.Parse(Console.ReadLine());
        for (int currentPointToCheck = 0; currentPointToCheck < numberOfPointsToCheck; currentPointToCheck++)
        {
            var currentInput = Console.ReadLine().Split();
            var currentPoint = new Point(int.Parse(currentInput[0]), int.Parse(currentInput[1]));

            Console.WriteLine(rectange.Contains(currentPoint));
        }
    }
}