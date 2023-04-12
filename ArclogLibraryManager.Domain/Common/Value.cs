namespace ArclogLibraryManager.Domain.Common;

public abstract record Value<TParent>() where TParent : IEntity;
