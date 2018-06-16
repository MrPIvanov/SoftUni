namespace _01_AnonymousDownsite
{
    using System;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            var siteNumber = long.Parse(Console.ReadLine());

            var securityKey = long.Parse(Console.ReadLine());
            var totalLoss = 0.0m;

            for (int i = 0; i < siteNumber; i++)
            {
                var siteInput = Console.ReadLine().Split();
                Console.WriteLine(siteInput[0]);

                var siteVisits = long.Parse(siteInput[1]);
                var pricePerVisit = decimal.Parse(siteInput[2]);

                totalLoss += siteVisits * pricePerVisit;
            }

            Console.WriteLine($"Total Loss: {totalLoss:f20}");


            var tokens = new BigInteger();
            tokens = 1;

            for (int i = 0; i < siteNumber; i++)
            {
                tokens *= securityKey;
            }

            Console.WriteLine($"Security Token: {tokens}");
        }
    }
}