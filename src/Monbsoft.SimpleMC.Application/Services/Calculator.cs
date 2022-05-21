using Monbsoft.SimpleMC.Application.Interfaces;
using Monbsoft.SimpleMC.Application.Models;

namespace Monbsoft.SimpleMC.Application.Services;

public class Calculator
{
    private readonly IRuleManager _ruleManager;
    private readonly Random _random;

    public Calculator(IRuleManager ruleManager)
    {
        _random = new Random();

        _ruleManager = ruleManager;
    }

    /// <summary>
    /// Geneates operations by applying the rules.
    /// </summary>
    /// <returns></returns>
    public List<OperationBase> GenerateOperations(GameContext context)
    {
        if(context == null) throw new ArgumentNullException(nameof(context)); 

        List<OperationBase> operations = new List<OperationBase>();
        _ruleManager.Generate(context);
        var rule = _ruleManager.Choosee(context);

        for (int i = 0; i < 10; i++)
        {
            operations.Add(rule.Generate(context));
        }

        return operations;
    }

}
