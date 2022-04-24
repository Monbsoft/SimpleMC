using Ardalis.GuardClauses;
using Monbsoft.SimpleMC.SharedKernel;

namespace Monbsoft.SimpleMC.Application.Domain;

public class Part : BaseEntity, IAggregateRoot
{
    private readonly List<Calculation> _calculations;

    public Part()
    {
        _calculations = new List<Calculation>();
    }

    public IEnumerable<Calculation> Calculations => _calculations.AsReadOnly();


    public void AddCalculation(Calculation calculation)
    {
        Guard.Against.Null(calculation, nameof(calculation));
        _calculations.Add(calculation);
    }     
}
