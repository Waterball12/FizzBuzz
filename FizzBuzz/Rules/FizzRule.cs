namespace FizzBuzz.Rules;

public class FizzRule : IFizzBuzzRule
{
    public int Priority => 3;
    
    public bool Matches(int number)
    {
        return number % 3 == 0;
    }

    public string GetReplacement()
    {
        return "Fizz";
    }
}