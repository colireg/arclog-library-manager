using ArclogLibraryManager.Domain.BookAggregate;

namespace ArclogLibraryManager.Domain.Aggregates.BookAggregate.Events;

public record BookAuthorAdded(
    Guid EventId,
    DateTime OccuredAt,
    Id<Book> EntityId,
    BookAuthor Author)
    : DomainEvent<Book>(EventId, OccuredAt, EntityId);