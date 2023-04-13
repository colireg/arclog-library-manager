using ArclogLibraryManager.Domain.BookAggregate;

namespace ArclogLibraryManager.Domain.Aggregates.BookAggregate.Events;

public record BookCoverImageUpdated(
    Guid EventId,
    DateTime OccuredAt,
    Id<Book> EntityId,
    BookCoverImage Image)
    : DomainEvent<Book>(EventId, OccuredAt, EntityId);