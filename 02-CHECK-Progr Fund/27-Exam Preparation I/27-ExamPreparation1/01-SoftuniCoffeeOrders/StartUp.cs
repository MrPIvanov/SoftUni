namespace _01_SoftuniCoffeeOrders
{
    using System;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            var orders = int.Parse(Console.ReadLine());
            var totalPrice = 0.0m;
            

            for (int i = 0; i < orders; i++)
            {
                var price = decimal.Parse(Console.ReadLine());
                var date = DateTime.ParseExact(Console.ReadLine(),"d/M/yyyy",System.Globalization.CultureInfo.InvariantCulture);
                var daysInMonth = DateTime.DaysInMonth(date.Year,date.Month);
                var capsules = long.Parse(Console.ReadLine());
                var pricePerMonth = daysInMonth*capsules;
                decimal currentPrice = price * pricePerMonth;
                totalPrice += currentPrice;

                Console.WriteLine($"The price for the coffee is: ${currentPrice:f2}");

            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}