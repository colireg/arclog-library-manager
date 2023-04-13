using ArclogLibraryManager.Domain.BookAggregate;

namespace ArclogLibraryManager.Domain.Aggregates.BookAggregate.Events;

public record BookTitleUpdated(
    Guid EventId,
    DateTime OccuredAt,
    Id<Book> EntityId,
    BookTitle Title)
    : DomainEvent<Book>(EventId, OccuredAt, EntityId);