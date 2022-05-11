namespace Monbsoft.SimpleMC.Application.Models;

public class Addition : OperationBase
{
    public Addition(Calculation calculation)
        : base(calculation)
    {
        if (calculation.Operator != Operator.Plus)
            throw new ArgumentException(nameof(calculation.Operator));
    }

    public override double Result => Calculation.Operand1 + Calculation.Operand2;

    public static Addition Create(double operand1, double operand2)
    {
        return new Addition(new Calculation(Operator.Plus, operand1, operand2));
    }
}
