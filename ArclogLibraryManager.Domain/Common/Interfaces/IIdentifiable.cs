namespace ArclogLibraryManager.Domain.Common.Interfaces;

public interface IIdentifiable<TParent> where TParent : IEntity
{
    public Id<TParent> Id { get; }
}
