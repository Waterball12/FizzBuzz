namespace FizzBuzz.Rules;

public class FizzBuzzRule : IFizzBuzzRule
{
    public int Priority => 15;
    
    public bool Matches(int number)
    {
        return number % 3 == 0 && number % 5 == 0;
    }

    public string GetReplacement()
    {
        return "FizzBuzz";
    }
}