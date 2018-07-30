using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        var lights = Console.ReadLine().Split().ToList();
        var numberOfChanges = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfChanges; i++)
        {
            var temp = new List<string>();

            foreach (var light in lights)
            {
                temp.Add(ReturnNextEnum(light));
            }
            Console.WriteLine(string.Join(" ", temp));

            lights = temp;
        }
    }

    public static string ReturnNextEnum(string value)
    {
        var currentNumber = (int)(LightsEnum)Enum.Parse(typeof(LightsEnum), value);
        currentNumber++;
        currentNumber %= 3;
        var enumToReturn = (LightsEnum)currentNumber;
        var result = enumToReturn.ToString();
        return result;

    }
}