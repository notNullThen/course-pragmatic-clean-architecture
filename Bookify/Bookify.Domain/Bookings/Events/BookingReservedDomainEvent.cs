using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Bookings.Events;

internal record BookingReservedDomainEvent(Guid BookingId) : IDomainEvent;
