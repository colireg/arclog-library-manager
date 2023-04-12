using System.Collections.Immutable;

namespace ArclogLibraryManager.Domain.Common;

public abstract class AggregateRoot<T> : IEntity, IIdentifiable<T>, IInternalEventHandler<T>
    where T : AggregateRoot<T>
{
    public Id<T> Id { get; protected set; } = default!;

    private readonly IList<DomainEvent<T>> _events = new List<DomainEvent<T>>();

    protected abstract void When(DomainEvent<T> e);

    protected abstract void ValidateState();

    protected void ApplyToChildEntity(IInternalEventHandler<T> entity,  DomainEvent<T> e)
        => entity.Handle(e);

    protected void Apply(DomainEvent<T> e)
    {
        When(e);
        ValidateState();
        _events.Add(e);
    }

    public void ClearEvents() => _events.Clear();

    public IImmutableList<DomainEvent<T>> GetEvents() => ImmutableArray.ToImmutableArray(_events);

    void IInternalEventHandler<T>.Handle(DomainEvent<T> e) => When(e);

}
