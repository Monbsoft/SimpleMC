using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monbsoft.SimpleMC.SharedKernel
{
    public interface IHandler<T> where T : IDomainEvent
    {
        void Handle(T domainEvent);
    }
}
