namespace Monbsoft.SimpleMC.Application.Models;

public class Division : OperationBase
{
    public Division(Calculation calculation)
        : base(calculation)
    {
        if(calculation.Operator != Operator.Divide)
            throw new ArgumentException(nameof(calculation.Operator));
    }

    public override double Result => Calculation.Operand1 / Calculation.Operand2;

    public static Division Create(double operand1, double operand2)
    {
        return new Division(new Calculation(Operator.Divide, operand1, operand2));
    }
}
