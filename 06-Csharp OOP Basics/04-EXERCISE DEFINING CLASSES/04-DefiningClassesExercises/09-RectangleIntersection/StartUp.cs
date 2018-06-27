using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main()
    {
        var input = Console.ReadLine().Split();
        var numberOfRectangles = int.Parse(input[0]);
        var numberOfChecks = int.Parse(input[1]);
        var allRectangles = new List<Rectangle>();

        for (int i = 0; i < numberOfRectangles; i++)
        {
            var inputRectangle = Console.ReadLine();
            var tempRectangle = new Rectangle(inputRectangle);
            allRectangles.Add(tempRectangle);
        }
        for (int i = 0; i < numberOfChecks; i++)
        {
            var args = Console.ReadLine().Split();
            var firstID = args[0];
            var secondID = args[1];

            var first = allRectangles.Where(x => x.Id == firstID).FirstOrDefault();
            var second = allRectangles.Where(x => x.Id == secondID).FirstOrDefault();

            Console.WriteLine(first.IsThereIntersection(second) ? "true" : "false");

        }

    }
       
}