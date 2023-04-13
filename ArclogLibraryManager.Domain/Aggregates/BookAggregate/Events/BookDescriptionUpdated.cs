using ArclogLibraryManager.Domain.BookAggregate;

namespace ArclogLibraryManager.Domain.Aggregates.BookAggregate.Events;

public record BookDescriptionUpdated(
    Guid EventId,
    DateTime OccuredAt,
    Id<Book> EntityId,
    BookDescription Description)
    : DomainEvent<Book>(EventId, OccuredAt, EntityId);