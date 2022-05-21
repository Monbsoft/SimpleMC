using Monbsoft.SimpleMC.Application.Interfaces;

namespace Monbsoft.SimpleMC.Application.Models;

public abstract class OperationBase : IOperation
{
    public OperationBase(Calculation calculation)
    {
        Calculation = calculation ?? throw new ArgumentNullException(nameof(calculation));
    }

    public Calculation Calculation { get; }
    public abstract double Result { get; }
}
