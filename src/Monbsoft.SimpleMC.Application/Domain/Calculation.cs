using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monbsoft.SimpleMC.Application.Domain
{
    public class Calculation
    {
        public Calculation(Operator @operator, double operand1, double operand2)
        {
            Operand1 = operand1;
            Operand2 = operand2;
        }

        public double Operand1 { get; }
        public double Operand2 { get; }
        public Operator Operator { get; }
        public double Result { get; }

        public override string ToString()
        {
            return $"({Operator} {Operand1}, {Operand2})";
        }

    }
}
