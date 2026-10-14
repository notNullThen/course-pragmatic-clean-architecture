using Bookify.Application.Abstractions.Messaging;

namespace Bookify.Application.Bookings.ReservedBooking;

internal record ReserveBookingCommand(
    Guid ApartmentId,
    Guid UserId,
    DateOnly StartDate,
    DateOnly EndDate) : ICommand<Guid>;