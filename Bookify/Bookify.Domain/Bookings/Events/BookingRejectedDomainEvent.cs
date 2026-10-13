using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Bookings.Events;

internal record BookingRejectedDomainEvent(Guid BookingId) : IDomainEvent;
