namespace Monbsoft.SimpleMC.SharedKernel;

public interface IHandler<T> where T : IDomainEvent
{
    void Handle(T domainEvent);
}
