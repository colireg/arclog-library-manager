using ArclogLibraryManager.Domain.BookAggregate;

namespace ArclogLibraryManager.Domain.Aggregates.BookAggregate;

public class BookAuthor : Entity<BookAuthor, Book>
{
    public string? FirstName { get; private set; }

    public string? LastName { get; private set; }

    public string? PenName { get; private set; }

    public DateOnly? DateOfBirth { get; private set; }

    protected BookAuthor()
    {
    }

    public BookAuthor(string? firstName, string? lastName, string? penName, DateOnly? dateOfBirth) : this()
    {
        FirstName = firstName;
        LastName = lastName;
        PenName = penName;
        DateOfBirth = dateOfBirth;
    }

    protected void ValidateState()
    {
        bool hasAtLeastOneName =
            !string.IsNullOrWhiteSpace(FirstName)
            || !string.IsNullOrWhiteSpace(LastName)
            || !string.IsNullOrWhiteSpace(PenName);

        if (!hasAtLeastOneName)
            throw new InvalidEntityStateException(this, "Author must have at least one name");

        bool areNamesValid = ValidateName(FirstName) && ValidateName(LastName) && ValidateName(PenName);

        if (!areNamesValid)
            throw new InvalidEntityStateException(this, "Author names must be less than 64 characters");
    }

    private static bool ValidateName(string? name) => string.IsNullOrWhiteSpace(name) || name.Length < 64;

    protected override void When(DomainEvent<Book> e)
    {
        throw new NotImplementedException();
    }
}
