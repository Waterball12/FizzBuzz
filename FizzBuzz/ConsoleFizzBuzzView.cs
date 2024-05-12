namespace FizzBuzz;

public class ConsoleFizzBuzzView : IFizzBuzzView
{
    public void Display(IEnumerable<FizzBuzzResult> results)
    {
        foreach (var result in results)
        {
            if (result.Rule != null)
            {
                Console.WriteLine(result.Rule.GetReplacement());
            }
            else
            {
                Console.WriteLine(result.Value);
            }
        }
    }
}