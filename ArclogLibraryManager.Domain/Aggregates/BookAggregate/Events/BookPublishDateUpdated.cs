using ArclogLibraryManager.Domain.BookAggregate;

namespace ArclogLibraryManager.Domain.Aggregates.BookAggregate.Events;

public record BookPublishDateUpdated(
    Guid EventId,
    DateTime OccuredAt,
    Id<Book> EntityId,
    DateTime PublishDate)
    : DomainEvent<Book>(EventId, OccuredAt, EntityId);