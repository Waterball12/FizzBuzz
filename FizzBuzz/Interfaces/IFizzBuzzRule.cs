namespace FizzBuzz;

public interface IFizzBuzzRule
{
    int Priority { get; }
    bool Matches(int number);
    string GetReplacement();
}