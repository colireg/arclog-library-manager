using ArclogLibraryManager.Domain.BookAggregate;

namespace ArclogLibraryManager.Domain.Aggregates.BookAggregate;

public record BookTitle : Value<Book>
{
    public string Value { get; protected set; } = default!;

    public static BookTitle FromString(string value)
    {
        Validate(value);
        return new BookTitle(value);
    }

    protected BookTitle(string value) : this()
    {
        Value = value;
    }

    protected BookTitle()
    {
    }

    protected static void Validate(string value)
    {
        bool isValid =
            !string.IsNullOrWhiteSpace(value)
            && value.Length < 512;

        if (!isValid)
            throw new ArgumentOutOfRangeException(nameof(value), "Title cannot be empty or more than 512 characters long");
    }
}

