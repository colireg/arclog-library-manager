using ArclogLibraryManager.Domain.BookAggregate;

namespace ArclogLibraryManager.Domain.Aggregates.BookAggregate.Events;

public record BookCreated(
    Guid EventId,
    DateTime OccuredAt,
    Id<Book> EntityId,
    BookTitle Title,
    BookDescription Description)
    : DomainEvent<Book>(EventId, OccuredAt, EntityId);