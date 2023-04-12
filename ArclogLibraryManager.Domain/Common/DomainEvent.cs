namespace ArclogLibraryManager.Domain.Common;

public abstract record DomainEvent<TAgg>(
    Guid EventId,
    Id<TAgg> EntityId,
    DateTime OccuredAt)
    where TAgg : AggregateRoot<TAgg>;