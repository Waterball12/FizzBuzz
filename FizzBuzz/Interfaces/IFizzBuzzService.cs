namespace FizzBuzz;

public interface IFizzBuzzService
{
    IEnumerable<FizzBuzzResult> Generate(int start, int end);
}