namespace ArclogLibraryManager.Domain.Common.Interfaces;

public interface IAuditableEntity
{
    public DateTime CreatedAt { get; }

    public DateTime LastModifiedAt { get; }
}
