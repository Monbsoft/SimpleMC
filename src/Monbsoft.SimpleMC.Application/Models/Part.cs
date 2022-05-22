using Ardalis.GuardClauses;
using Monbsoft.SimpleMC.SharedKernel;

namespace Monbsoft.SimpleMC.Application.Models;

public class Part : BaseEntity, IAggregateRoot
{
    private readonly List<OperationBase> _operations;
    private readonly IEnumerator<OperationBase> _enumerator;

    public Part(IEnumerable<OperationBase> operations)
    {
        if(operations == null) throw new ArgumentNullException(nameof(operations));
        Total = operations.Count();
        _enumerator = operations.GetEnumerator();
        _operations = operations.ToList();
    }

    public int Count => _operations.Count;
    public OperationBase Current => _enumerator.Current;
    public bool HasNext => _operations.Any();
    public int Total { get; }
    public bool MoveNext()
    {
        if(_operations.Any())
            _operations.RemoveAt(0);
        return _enumerator.MoveNext();
    }
}
