using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        
        var input = Console.ReadLine().Split().ToArray();
        var name = input[0] + " " + input[1];
        var adress = input[2];

        var tuple = new CustomTuple<string, string>(name,adress);
        Console.WriteLine(tuple);

        input = Console.ReadLine().Split().ToArray();
        var name2 = input[0];
        var beer = int.Parse(input[1]);

        var tuple2 = new CustomTuple<string, int>(name2,beer);
        Console.WriteLine(tuple2);

        input = Console.ReadLine().Split().ToArray();
        var firstParam = int.Parse(input[0]);
        var secondParam = double.Parse(input[1]);

        var tuple3 = new CustomTuple<int, double>(firstParam, secondParam);
        Console.WriteLine(tuple3);

    }
}