using Ardalis.GuardClauses;
using Monbsoft.SimpleMC.SharedKernel;

namespace Monbsoft.SimpleMC.Application.Models;

public class Part : BaseEntity, IAggregateRoot
{
    private readonly List<OperationBase> _operations;

    public Part()
    {
        _operations = new List<OperationBase>();
    }

    public IEnumerable<OperationBase> Operations => _operations.AsReadOnly();


    public void AddOperation(OperationBase operation)
    {
        Guard.Against.Null(operation, nameof(operation));
        _operations.Add(operation);
    }
}
