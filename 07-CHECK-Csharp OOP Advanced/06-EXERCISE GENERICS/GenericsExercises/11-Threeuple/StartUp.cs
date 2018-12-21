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
        var town = input[3];

        var tuple = new CustomTuple<string, string, string>(name, adress,town);
        Console.WriteLine(tuple);

        input = Console.ReadLine().Split().ToArray();
        var name2 = input[0];
        var beer = int.Parse(input[1]);
        var drunkOrNot = input[2];
        bool drunk = drunkOrNot == "drunk";

        var tuple2 = new CustomTuple<string, int, bool>(name2, beer,drunk);
        Console.WriteLine(tuple2);

        input = Console.ReadLine().Split().ToArray();
        var name3 = input[0];
        var acountBalance = double.Parse(input[1]);
        var bankName = input[2];

        var tuple3 = new CustomTuple<string, double, string>(name3, acountBalance, bankName);
        Console.WriteLine(tuple3);

    }
}