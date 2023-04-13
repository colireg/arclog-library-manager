namespace ArclogLibraryManager.Domain.Common;

public abstract record DomainEvent<TAgg>(
    Guid EventId,
    DateTime OccuredAt,
    Id<TAgg> EntityId)
    where TAgg : AggregateRoot<TAgg>;