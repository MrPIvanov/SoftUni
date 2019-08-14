using System;
using System.Collections.Generic;
using System.Linq;

public class SumOfCoins
{
    public static void Main()
    {
        var availableCoins = new[] { 1, 2, 5, 10, 20, 50 };
        var targetSum = 923;

        var selectedCoins = ChooseCoins(availableCoins, targetSum);

        Console.WriteLine($"Number of coins to take: {selectedCoins.Values.Sum()}");
        foreach (var selectedCoin in selectedCoins)
        {
            Console.WriteLine($"{selectedCoin.Value} coin(s) with value {selectedCoin.Key}");
        }
    }

    public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
    {
        var result = new Dictionary<int, int>();
        coins = coins.OrderByDescending(x => x).ToList();
        var index = 0;

        while (targetSum > 0)
        {
            if (index == coins.Count)
            {
                throw new InvalidOperationException();
            }

            if (targetSum >= coins[index])
            {
                result[coins[index]] = targetSum / coins[index];
                targetSum = targetSum % coins[index];
                index++;
            }
            else
            {
                index++;
            }
        }

        return result;
    }
}
