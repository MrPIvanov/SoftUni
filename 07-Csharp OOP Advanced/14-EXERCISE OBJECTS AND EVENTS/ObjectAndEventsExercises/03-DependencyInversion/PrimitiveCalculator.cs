public class PrimitiveCalculator
{
    private ICalculate strategy;

    public PrimitiveCalculator(ICalculate strategy)
    {
        this.strategy = strategy;
    }

    public int PerformCalculation(int firstOperand, int secondOperand)
    {
        var result = this.strategy.Calculate(firstOperand, secondOperand);
        return result;
    }

    public void ChangeStrategy(ICalculate strategy)
    {
        this.strategy = strategy;
    }
}