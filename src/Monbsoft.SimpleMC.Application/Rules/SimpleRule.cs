using Monbsoft.SimpleMC.Application.Domain;
using Monbsoft.SimpleMC.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monbsoft.SimpleMC.Application.Rules;

public class SimpleRule : IRule
{
    private readonly Random random = new Random();

    /// <summary>
    /// Generates a calculation
    /// </summary>
    /// <returns>A calculation</returns>
    public Calculation Generate()
    {
        double operand1 = Convert.ToDouble(random.Next(100));
        double operand2 = Convert.ToDouble(random.Next(100));

        return new Calculation(Operator.Plus, operand1, operand2);
    }
}
