namespace Monbsoft.SimpleMC.Application.Models;

public class Multiplication : OperationBase
{
    public Multiplication(Calculation calculation)
        : base(calculation)
    {
        if (calculation.Operator != Operator.Times)
            throw new ArgumentException(nameof(calculation.Operator));
    }

    public override double Result => Calculation.Operand1 * Calculation.Operand2;

    public static Multiplication Create(double operand1, double operand2)
    {
        return new Multiplication(new Calculation(Operator.Times, operand1, operand2));
    }
}
