using ArclogLibraryManager.Domain.BookAggregate;

namespace ArclogLibraryManager.Domain.Aggregates.BookAggregate.Events;

public record BookDeleted(
    Guid EventId,
    DateTime OccuredAt,
    Id<Book> EntityId,
    DateTime DeletedAt)
    : DomainEvent<Book>(EventId, OccuredAt, EntityId);
