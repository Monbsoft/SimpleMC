using Monbsoft.SimpleMC.Application.Domain;
using Monbsoft.SimpleMC.Application.Interfaces;

namespace Monbsoft.SimpleMC.Application.Services;

public class Calculator
{
    private readonly List<IRule> _rules;
    private readonly Random _random;

    public Calculator(List<IRule> rules)
    {
        _rules = rules;
        _random = new Random();
    }

    /// <summary>
    /// Creates calculations by applying the rules.
    /// </summary>
    /// <returns></returns>
    public Part CreatePart()
    {
        var part = new Part();
        var rule = ChooseRule();

        for (int i = 0; i < 10; i++)
        {
            part.AddCalculation(rule.Generate());
        }

        return part;
    }

    /// <summary>
    /// Chooses a rule at random
    /// </summary>
    /// <returns>A calculation rule</returns>
    private IRule ChooseRule()
    {

        if (_rules.Count == 1)
            return _rules.First();

        int index = _random.Next(0, _rules.Count);
        return _rules[index];

    }


}
