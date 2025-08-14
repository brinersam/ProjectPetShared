namespace ProjectPet.SharedKernel.Entities.AbstractBase;
public abstract class DomainEventEntity : EntityBase
{
    protected DomainEventEntity(Guid id)
        : base(id)
    { }

    public IReadOnlyList<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

    private List<IDomainEvent> _domainEvents = [];

    public void AddDomainEvent(IDomainEvent domainEvent) => _domainEvents.Add(domainEvent);

    public void ClearDomainEvents() => _domainEvents.Clear();
}