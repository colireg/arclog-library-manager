namespace ArclogLibraryManager.Domain.Common.Interfaces;

public interface IInternalEventHandler<TAgg> where TAgg : AggregateRoot<TAgg>
{
    void Handle(DomainEvent<TAgg> e);
}
