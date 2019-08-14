using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        var allPersons = new List<Person>();
        var allProducts = new List<Product>();

        var personsInput = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        var productsInput = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        FillAllPersons(allPersons, personsInput);
        FillAllProducts(allProducts, productsInput);

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            BuyProducts(input, allPersons, allProducts);
        }

        PrintResults(allPersons);
    }

    private static void PrintResults(List<Person> allPersons)
    {

        foreach (var person in allPersons)
        {
            if (person.ProductsBouth.Count() == 0)
            {
                Console.WriteLine($"{person.Name} - Nothing bought");
            }
            else
            {
                Console.WriteLine($"{person.Name} - {string.Join(", ", person.ProductsBouth)}");

            }
        }
    }

    private static void BuyProducts(string input, List<Person> allPersons, List<Product> allProducts)
    {
        var args = input.Split();
        var personName = args[0];
        var productName = args[1];

        var currentPerson = allPersons.First(x => x.Name == personName);
        var currentProduct = allProducts.First(x => x.Name == productName);
        if (currentPerson.Money >= currentProduct.Price)
        {
            Console.WriteLine($"{currentPerson.Name} bought {currentProduct.Name}");
            currentPerson.ProductsBouth.Add(currentProduct.Name);
            currentPerson.Money -= currentProduct.Price;
        }
        else
        {
            Console.WriteLine($"{currentPerson.Name} can't afford {currentProduct.Name}");
        }
    }

    private static void FillAllProducts(List<Product> allProducts, string[] productsInput)
    {
        foreach (var product in productsInput)
        {
            var args = product.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var currentName = args[0];
            var currentCost = decimal.Parse(args[1]);

            try
            {
                var validator = new Validator();
                validator.ValidateMoney(currentCost);
                validator.ValidateName(currentName);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }

            var currentProduct = new Product(currentName, currentCost);
            allProducts.Add(currentProduct);

        }
    }

    private static void FillAllPersons(List<Person> allPersons, string[] personsInput)
    {
        foreach (var person in personsInput)
        {
            var args = person.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var currentName = args[0];
            var currentMoney = decimal.Parse(args[1]);
            try
            {
                var validator = new Validator();
                validator.ValidateMoney(currentMoney);
                validator.ValidateName(currentName);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }

            var currentPerson = new Person(currentName, currentMoney);
            allPersons.Add(currentPerson);

        }
    }
}