namespace ArclogLibraryManager.Domain.Common;

public abstract class Entity<T, TAgg> : IEntity, IIdentifiable<T>, IInternalEventHandler<TAgg>
    where T : IEntity
    where TAgg : AggregateRoot<TAgg>
{
    public Id<T> Id { get; protected set; } = default!;

    private readonly Action<DomainEvent<TAgg>>? _applier;

    protected Entity(Action<DomainEvent<TAgg>> applier) => _applier = applier;

    protected Entity()
    {
    }

    protected abstract void When(DomainEvent<TAgg> e);

    protected void Apply(DomainEvent<TAgg> e)
    {
        When(e);
        _applier?.Invoke(e);
    }

    void IInternalEventHandler<TAgg>.Handle(DomainEvent<TAgg> e) => When(e);
}
