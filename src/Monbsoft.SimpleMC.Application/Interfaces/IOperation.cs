using Monbsoft.SimpleMC.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monbsoft.SimpleMC.Application.Interfaces
{
    public interface IOperation
    {
        public Calculation Calculation { get; }
        public double Result { get; }

    }
}
