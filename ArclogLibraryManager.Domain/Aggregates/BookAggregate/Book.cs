using ArclogLibraryManager.Domain.Aggregates.BookAggregate;
using ArclogLibraryManager.Domain.Aggregates.BookAggregate.Events;

namespace ArclogLibraryManager.Domain.BookAggregate;

public class Book : AggregateRoot<Book>
{
    public BookTitle Title { get; protected set; } = default!;

    public readonly ICollection<BookAuthor> Authors = new List<BookAuthor>();

    public DateTime? PublishedAt { get; protected set; }

    public BookCoverImage? CoverImage { get; protected set; } = default!;

    public BookDescription? Description { get; protected set; } = default!;

    protected override void ValidateState()
    {
        bool isValid = Title != null;

        if (!isValid)
            throw new InvalidEntityStateException(this);
    }

    protected override void When(DomainEvent<Book> e)
    {
        switch (e)
        {
            case BookCreated @event:
                Id = @event.EntityId;
                Title = @event.Title;
                Description = @event.Description;
                break;

        }
    }
}
