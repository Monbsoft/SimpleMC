using Monbsoft.SimpleMC.Application.Models;

namespace Monbsoft.SimpleMC.Application.Interfaces
{
    public interface IRuleManager
    {
        IRule Choosee(GameContext context);
        void Generate(GameContext context);
    }
}