using System;

public class StartUp
{
    static void Main()
    {
        var calculator = new PrimitiveCalculator(new AdditionStrategy());

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var tokens = input.Split();

            if (tokens[0]=="mode")
            {
                switch (tokens[1])
                {
                    case "/":
                        calculator.ChangeStrategy(new DivisionStrategy());
                        break;

                    case "*":
                        calculator.ChangeStrategy(new MultyplicationStrategy());
                        break;

                    case "-":
                        calculator.ChangeStrategy(new SubtractionStrategy());
                        break;

                    case "+":
                        calculator.ChangeStrategy(new AdditionStrategy());
                        break;
                }
            }
            else
            {
                var firstNumber = int.Parse(tokens[0]);
                var secondNumber = int.Parse(tokens[1]);
                var result = calculator.PerformCalculation(firstNumber, secondNumber);
                Console.WriteLine(result);
            }
        }
    }
}