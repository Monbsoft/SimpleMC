using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monbsoft.SimpleMC.Application.Models;

public class GameContext
{
    public int Level { get; set; }
    public Operator? Operator { get; set; }
}
