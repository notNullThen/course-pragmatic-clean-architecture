using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Bookings.Events;

internal record BookingCancelledDomainEvent(Guid BookingId) : IDomainEvent;
