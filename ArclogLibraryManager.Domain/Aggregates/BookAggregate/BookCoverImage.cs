namespace ArclogLibraryManager.Domain.BookAggregate;

public record BookCoverImage(Uri Path) : Value<Book>
{
}
