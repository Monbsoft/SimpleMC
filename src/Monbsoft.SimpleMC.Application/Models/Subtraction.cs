namespace Monbsoft.SimpleMC.Application.Models;

public class Subtraction : OperationBase
{
    public Subtraction(Calculation calculation)
        : base(calculation)
    {

        if (calculation.Operator != Operator.Minus)
            throw new ArgumentException(nameof(calculation.Operator));
    }

    public override double Result => Calculation.Operand1 - Calculation.Operand2;

    public static Subtraction Create(double operand1, double operand2)
    {
        return new Subtraction(new Calculation(Operator.Minus, operand1, operand2));
    }
}
