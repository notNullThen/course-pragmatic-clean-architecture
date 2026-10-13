using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Bookings;

internal static class BookingErrors
{
    internal static Error NotFound => new("Booking.NotFound", "The booking with specified ID was not found.");

    internal static Error Overlap => new("Booking.Overlap", "The current booking is overlapping with an existing one.");

    internal static Error NotReserved => new("Booking.NotReserved", "The booking is not pending.");

    internal static Error NotConfirmed => new("Booking.NotConfirmed", "The booking is not confirmed.");

    internal static Error AlreadyStarted => new("Booking.AlreadyStarted", "The booking is not confirmed.");
}
