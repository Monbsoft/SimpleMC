using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monbsoft.SimpleMC.Application.Domain
{
    public enum Operator : ushort
    {
        Asign = '\0',
        Plus = '+',
        Minus = '-',
        Times = '*',
        Divide = '/',
        Pow = '^',
    }
}
