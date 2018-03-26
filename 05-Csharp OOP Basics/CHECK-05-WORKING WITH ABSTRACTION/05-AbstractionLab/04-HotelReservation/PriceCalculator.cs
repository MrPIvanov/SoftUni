using System;
using System.Collections.Generic;
using System.Text;

public class PriceCalculator
{
    private decimal PricePerDay { get; set; }
    private int Days { get; set; }
    private Season Season { get; set; }
    private Discount Discount { get; set; }

    public PriceCalculator(string inputStr)
    {
        var input = inputStr.Split();

        PricePerDay = decimal.Parse(input[0]);
        Days = int.Parse(input[1]);
        Season = Enum.Parse<Season>(input[2]);
        Discount = Discount.None;
        if (input.Length > 3)
        {
            Discount = Enum.Parse<Discount>(input[3]);
        }

    }

    public void Calculate()
    {
        decimal disc = ((decimal)100-(int)(Discount))/100;
        var total = PricePerDay * Days * (int)Season * disc;
        Console.WriteLine($"{total:f2}");
    }

}
