namespace FizzBuzz.Rules;

public class BuzzRule : IFizzBuzzRule
{
    public int Priority => 5;
    
    public bool Matches(int number)
    {
        return number % 5 == 0;
    }

    public string GetReplacement()
    {
        return "Buzz";
    }
}