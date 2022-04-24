using Monbsoft.SimpleMC.Application.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monbsoft.SimpleMC.Application.Interfaces;

public interface IRule
{
    Calculation Generate();
}
