using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Bookings.Events;

internal record BookingConfirmedDomainEvent(Guid BookingId) : IDomainEvent;
