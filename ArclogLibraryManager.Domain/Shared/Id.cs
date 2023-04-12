namespace ArclogLibraryManager.Domain.Shared;


public record Id<TParent>(Guid Value) : Value<TParent> where TParent : IEntity
{
    public Id() : this(Guid.NewGuid())
    {
    }

    public static implicit operator Id<TParent>(Guid guid) => new(guid);
}
