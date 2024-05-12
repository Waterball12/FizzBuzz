using FizzBuzz.Rules;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace FizzBuzz.Tests.Steps;

[Binding]
public class FizzBuzzSteps
{
    private readonly ScenarioContext _scenarioContext;
    
    public FizzBuzzSteps(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }
    
    [Given(@"I have a FizzBuzz game")]
    public void GivenIHaveAFizzBuzzGame()
    {
        var rules = new List<IFizzBuzzRule>
        {
            new FizzRule(),
            new BuzzRule(),
            new FizzBuzzRule()
        };
        
        var newGame = new FizzBuzzService(rules);
        
        _scenarioContext.Add("Game", newGame);
    }

    [When(@"I print numbers from (.*) to (.*)")]
    public void WhenIPrintNumbersFromTo(int p0, int p1)
    {
        var game = _scenarioContext.Get<FizzBuzzService>("Game");

        var result = game.Generate(p0, p1);

        _scenarioContext.Add("Result", result);
    }

    [Then(@"I should see the following output:")]
    public void ThenIShouldSeeTheFollowingOutput(Table table)
    {
        var expectedOutput = table.Rows.Select(row => row[0]).ToArray();
        var result = _scenarioContext.Get<IEnumerable<FizzBuzzResult>>("Result");

        var fizzBuzzResults = result.ToArray();
        
        for (int i = 0; i < fizzBuzzResults.Count(); i++)
        {
            var targetResult = fizzBuzzResults[i];
            var fizzBuzzResult = targetResult.Rule != null ? targetResult.Rule.GetReplacement() : targetResult.Value.ToString();
            fizzBuzzResult.Should().Be(expectedOutput[i]);
        }
    }
}