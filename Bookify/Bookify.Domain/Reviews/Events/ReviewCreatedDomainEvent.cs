using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Reviews.Events;

internal sealed record ReviewCreatedDomainEvent(Guid ReviewId) : IDomainEvent;