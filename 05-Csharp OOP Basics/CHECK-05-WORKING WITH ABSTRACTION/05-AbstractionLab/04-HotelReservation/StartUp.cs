using System;

public class StartUp
{
    static void Main()
    {
        var input = Console.ReadLine();
        var priceCalculator = new PriceCalculator(input);

        priceCalculator.Calculate();
    }
}