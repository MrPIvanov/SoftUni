using System;

class StartUp
{
    static void Main()
    {
        var firstDate = Console.ReadLine();
        var lastDate = Console.ReadLine();
        var dateModifier = new DateModifier();

        var result = dateModifier.CalculateDifrence(firstDate,lastDate);

        Console.WriteLine(Math.Abs(result));
    }
}