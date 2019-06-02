using System;
using System.Numerics;

public class StartUp
{
    static BigInteger[] facVals;

    public static void Main()
    {

        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        facVals = new BigInteger[k + 1];
        facVals[0] = 1;
        facVals[1] = 1;

        for (int i = 1; i < k + 1; i++)
        {
            CalcFact(i);
        }

        BigInteger result = facVals[k] / (facVals[n] * (facVals[k - n]));
        Console.WriteLine(result);
    }

    private static BigInteger CalcFact(int number)
    {
        if (facVals[number] != 0)
        {
            return facVals[number];
        }

        facVals[number] = facVals[number - 1] * number;
        return facVals[number];
    }

}