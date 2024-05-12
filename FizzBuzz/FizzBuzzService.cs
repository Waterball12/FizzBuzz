using System.Text;

namespace FizzBuzz;

public class FizzBuzzService : IFizzBuzzService
{
    private readonly IEnumerable<IFizzBuzzRule> _rules;

    public FizzBuzzService(IEnumerable<IFizzBuzzRule> rules)
    {
        _rules = rules.OrderByDescending(r => r.Priority);
    }

    public IEnumerable<FizzBuzzResult> Generate(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            yield return GenerateResult(i);
        }
    }

    private FizzBuzzResult GenerateResult(int number)
    {
        foreach (var rule in _rules)
        {
            if (rule.Matches(number))
            {
                return new FizzBuzzResult(rule, number);
            }
        }
        return new FizzBuzzResult(null, number);
    }
}