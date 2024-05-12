// See https://aka.ms/new-console-template for more information
using FizzBuzz;
using FizzBuzz.Rules;

var rules = new List<IFizzBuzzRule>
{
    new FizzRule(),
    new BuzzRule(),
    new FizzBuzzRule()
};

var fizzBuzzService = new FizzBuzzService(rules);
var fizzBuzzView = new ConsoleFizzBuzzView();

var results = fizzBuzzService.Generate(1, 100);
fizzBuzzView.Display(results);