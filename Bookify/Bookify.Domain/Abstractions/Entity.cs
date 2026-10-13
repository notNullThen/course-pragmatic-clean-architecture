namespace Bookify.Domain.Abstractions;

internal abstract class Entity(Guid id)
{
    private readonly List<IDomainEvent> _domainEvents = [];

    internal Guid Id => id;

    internal IReadOnlyList<IDomainEvent> GetDomainEvents() => _domainEvents.AsReadOnly();

    internal void ClearDomainEvents() => _domainEvents.Clear();

    protected void RaiseDomainEvent(IDomainEvent domainEvent) => _domainEvents.Add(domainEvent);
}
