using System;

public class StartUp
{
    static void Main()
    {
        Pizza pizza = null;
        try
        {
            var inputPizza = Console.ReadLine().Split();
            var pizzaName = inputPizza[1];
            pizza = new Pizza(pizzaName);

            var inputDough = Console.ReadLine().Split();
            var flourType = inputDough[1];
            var bakingTechnique = inputDough[2];
            var weight = double.Parse(inputDough[3]);
            var dough = new Dough(flourType, bakingTechnique, weight);

            pizza.Dough = dough;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
            Environment.Exit(0);
        }

        try
        {
            string toppingLine;
            while ((toppingLine = Console.ReadLine()) != "END")
            {
                var args = toppingLine.Split();
                var currentToppingType = args[1];
                var currentToppingWeight = double.Parse(args[2]);

                var currentTopping = new Topping(currentToppingType, currentToppingWeight);

                pizza.AddTopping(currentTopping);
            }

            pizza.CalculateTotalCal();

            Console.WriteLine($"{pizza.Name} - {pizza.TotalCal:f2} Calories.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
            Environment.Exit(0);
        }
    }


}
