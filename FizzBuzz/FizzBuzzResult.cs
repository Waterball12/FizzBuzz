namespace FizzBuzz;

public class FizzBuzzResult
{
    public IFizzBuzzRule? Rule { get; }
    public int Value { get; }

    public FizzBuzzResult(IFizzBuzzRule? rule, int value)
    {
        Rule = rule;
        Value = value;
    }
}