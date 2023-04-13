using ArclogLibraryManager.Domain.BookAggregate;

namespace ArclogLibraryManager.Domain.Aggregates.BookAggregate.Events;

public record BookAuthorRemoved(
    Guid EventId,
    DateTime OccuredAt,
    Id<Book> EntityId,
    Id<BookAuthor> AuthorId)
    : DomainEvent<Book>(EventId, OccuredAt, EntityId);