namespace ArclogLibraryManager.Domain.Exceptions;

public class InvalidEntityStateException : DomainException
{

    public InvalidEntityStateException(IEntity entity, string message)
    : base($"Entity {entity.GetType().Name} state change rejected: {message}")
    {
    }

    public InvalidEntityStateException(IEntity entity)
        : base($"Entity {entity.GetType().Name} state change rejected")
    {
    }
}
