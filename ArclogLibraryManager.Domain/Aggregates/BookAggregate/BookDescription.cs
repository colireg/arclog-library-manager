using ArclogLibraryManager.Domain.BookAggregate;

namespace ArclogLibraryManager.Domain.Aggregates.BookAggregate;

public record BookDescription : Value<Book>
{
    public string Value { get; protected set; } = default!;

    public static BookDescription FromString(string value)
    {
        Validate(value);
        return new BookDescription(value);
    }

    protected BookDescription(string value) : this()
    {
        Value = value;
    }

    protected BookDescription()
    {
    }

    protected static void Validate(string value)
    {
        bool isValid =
            !string.IsNullOrWhiteSpace(value)
            && value.Length < 1024;

        if (!isValid)
            throw new ArgumentOutOfRangeException(nameof(value), "Description cannot be empty or more than 1024 characters long");
    }
}
