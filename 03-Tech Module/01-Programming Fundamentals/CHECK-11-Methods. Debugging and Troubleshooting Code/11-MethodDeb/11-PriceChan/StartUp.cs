namespace _11_PriceChan
{
    using System;

    class StartUp
    {
        static void Main()
        {
            int numberOfPricesToCalculate = int.Parse(Console.ReadLine());

            double borderOfImportantDiffrence = double.Parse(Console.ReadLine());

            double firstPrice = double.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfPricesToCalculate-1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());

                double currentDiffrence = FindTheCurrentDiffrence(firstPrice, currentPrice);

                bool isSignificantDifference = CalculateTheDiffrenceImportant(currentDiffrence, borderOfImportantDiffrence);

                string endResult = GetTheMessage(currentPrice, firstPrice, currentDiffrence, isSignificantDifference);

                Console.WriteLine(endResult);

                firstPrice = currentPrice;
            }
        }

        static string GetTheMessage(double currentPrice, double firstPrice, double currentDiffrence, bool isSignificantDifference)
        {
            string currentMessage = "";

            if (currentDiffrence == 0)
            {
                currentMessage = string.Format($"NO CHANGE: {currentPrice}");
            }

            else if (!isSignificantDifference)
            {
                currentMessage = string.Format($"MINOR CHANGE: {firstPrice} to {currentPrice} ({currentDiffrence*100:f2}%)");
            }

            else if (isSignificantDifference && (currentDiffrence > 0))
            {
                currentMessage = string.Format($"PRICE UP: {firstPrice} to {currentPrice} ({currentDiffrence * 100:f2}%)");
            }

            else if (isSignificantDifference && (currentDiffrence < 0))
            {
                currentMessage = string.Format($"PRICE DOWN: {firstPrice} to {currentPrice} ({currentDiffrence*100:f2}%)");

            }

            return currentMessage;
        }

        static bool CalculateTheDiffrenceImportant(double currentDiffrence, double borderOfImportantDiffrence)
        {
            if (Math.Abs(currentDiffrence) >= borderOfImportantDiffrence)
            {
                return true;
            }
            return false;
        }

        static double FindTheCurrentDiffrence(double firstPrice, double currentPrice)
        {
            double currentDiffrence = (currentPrice-firstPrice) / firstPrice;
            return currentDiffrence;
        }
    }
}

