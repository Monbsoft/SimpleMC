namespace Monbsoft.SimpleMC.Application.Models;

public abstract class OperationBase
{
    public OperationBase(Calculation calculation)
    {
        Calculation = calculation ?? throw new ArgumentNullException(nameof(calculation));
    }

    public Calculation Calculation { get; }
    public abstract double Result { get; }
}
