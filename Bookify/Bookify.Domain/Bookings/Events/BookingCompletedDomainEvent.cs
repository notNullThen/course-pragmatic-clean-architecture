using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Bookings.Events;

internal record BookingCompletedDomainEvent(Guid BookingId) : IDomainEvent;
