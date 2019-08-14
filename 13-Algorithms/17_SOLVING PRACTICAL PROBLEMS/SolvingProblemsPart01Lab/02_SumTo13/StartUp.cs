﻿using System;
using System.Linq;

public class StartUp
{
    private const int TargetSum = 13;

    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var isTargetSum =
            numbers[0] + numbers[1] + numbers[2] == TargetSum
            || numbers[0] + numbers[1] - numbers[2] == TargetSum
            || numbers[0] - numbers[1] + numbers[2] == TargetSum
            || numbers[0] - numbers[1] - numbers[2] == TargetSum
            || -numbers[0] + numbers[1] + numbers[2] == TargetSum
            || -numbers[0] + numbers[1] - numbers[2] == TargetSum
            || -numbers[0] - numbers[1] + numbers[2] == TargetSum
            || -numbers[0] - numbers[1] - numbers[2] == TargetSum;

        Console.WriteLine(isTargetSum ? "Yes" : "No");
    }
}