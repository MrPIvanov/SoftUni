namespace _04_SupermData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var result = new Dictionary<string, Dictionary<double, int>>();


            while (input!="stocked")
            {
                string[] inputArr = input.Split().ToArray();
                string name = inputArr[0];
                double price = double.Parse(inputArr[1]);
                int quantity = int.Parse(inputArr[2]);
                var priceQuantity = new Dictionary<double, int>();
                priceQuantity.Add(price, quantity);
               

                if (result.ContainsKey(name))
                {

                    result[name]                /// to do adding
                }
                else
                {
                    result.Add(name,priceQuantity);
                }













                input = Console.ReadLine();
            }

            Console.WriteLine("ffff");
        }
    }
}