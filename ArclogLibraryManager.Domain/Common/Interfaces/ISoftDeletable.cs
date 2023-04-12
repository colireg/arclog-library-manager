namespace ArclogLibraryManager.Domain.Common.Interfaces;

public interface ISoftDeletable<TParent> where TParent : IEntity
{
    public DateTime? DeletedAt { get; }
}
